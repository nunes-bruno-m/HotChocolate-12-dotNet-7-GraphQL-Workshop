using HotChocolate.Types.Descriptors;
using Mykel.GraphQL.Data;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Mykel.GraphQL.Extensions
{
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
}
