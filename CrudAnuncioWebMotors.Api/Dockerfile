#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CrudAnuncioWebMotors.Api/CrudAnuncioWebMotors.Api.csproj", "CrudAnuncioWebMotors.Api/"]
RUN dotnet restore "CrudAnuncioWebMotors.Api/CrudAnuncioWebMotors.Api.csproj"
COPY . .
WORKDIR "/src/CrudAnuncioWebMotors.Api"
RUN dotnet build "CrudAnuncioWebMotors.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CrudAnuncioWebMotors.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CrudAnuncioWebMotors.Api.dll"]