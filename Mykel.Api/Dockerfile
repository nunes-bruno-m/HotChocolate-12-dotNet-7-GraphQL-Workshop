#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Mykel.GraphQL/Mykel.GraphQL.csproj", "Mykel.GraphQL/"]
RUN dotnet restore "Mykel.GraphQL/Mykel.GraphQL.csproj"
COPY . .
WORKDIR "/src/Mykel.GraphQL"
RUN dotnet build "Mykel.GraphQL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mykel.GraphQL.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mykel.GraphQL.dll"]