FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Era_Commerce/Era_Commerce.csproj", "Era_Commerce/"]
RUN dotnet restore "Era_Commerce/Era_Commerce.csproj"
COPY . .
WORKDIR "/src/Era_Commerce"
RUN dotnet build "Era_Commerce.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Era_Commerce.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Era_Commerce.dll"]
