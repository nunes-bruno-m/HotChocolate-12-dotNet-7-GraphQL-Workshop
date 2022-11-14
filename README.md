# Intro
This project was done by following the official [ChilliCream Hot Chocolate Workshop](https://github.com/ChilliCream/graphql-workshop), but using the versions
- Hot Chocolate 12.15.2
- .Net 7.0
- xUnit 2.4.2
- Snapshooter.XUnit 0.9.0


# What will be different compared to the workshop final code?
The workshop suits versions 11 and 12 until the session 6. In that session, you will face some issues regarding DbContext being disposed or issues calling mutations using string id's.
The first step was to follow the [official migration guide](https://chillicream.com/docs/hotchocolate/api-reference/migrate-from-11-to-12), more specifically
- [Records type](https://chillicream.com/docs/hotchocolate/api-reference/migrate-from-11-to-12#records)
    - Will fix the issues related to passing a string id instead of a number
- [Relay - Global object identification](https://chillicream.com/docs/hotchocolate/api-reference/migrate-from-11-to-12#global-object-identification)
- [Relay - Query field in mutation payloads](https://chillicream.com/docs/hotchocolate/api-reference/migrate-from-11-to-12#query-field-in-mutation-payloads)
- [DataLoader](https://chillicream.com/docs/hotchocolate/api-reference/migrate-from-11-to-12#dataloader)

Also, there is a detail on attributes order that can lead you to have an error message like:

*The middleware pipeline order for the field 'something' is invalid. Middleware order is important especially with data pipelines. The correct order of a data pipeline is as follows: UseDbContext -> UsePaging -> UseProjection -> UseFiltering -> UseSorting. You may omit any of these middleware or have other middleware in between but you need to abide by the overall order. Your order is: UseDbContext -> UsePaging -> UseDbContext.... (HotChocolate.Types.ObjectType)*

I solved by adding the order parameter in the UseApplicationDbContextAttribute as suggested in [this post](https://github.com/ChilliCream/hotchocolate/issues/4416#issuecomment-966933244)

```csharp
    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public UseApplicationDbContextAttribute([CallerLineNumber] int order = 0)
        {
            Order = order;
        }
        public override void OnConfigure(
            IDescriptorContext context,
            IObjectFieldDescriptor descriptor,
            MemberInfo member)
        {
            descriptor.UseDbContext<ApplicationDbContext>();
        }
    }
```