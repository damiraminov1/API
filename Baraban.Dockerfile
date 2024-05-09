FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY . .

RUN dotnet restore "Server/BarabanWebAPI/BarabanWebAPI.csproj"

RUN dotnet build "Server/BarabanWebAPI/BarabanWebAPI.csproj" -o /build

FROM build as publish
RUN dotnet publish "Server/BarabanWebAPI/BarabanWebAPI.csproj" -o /publish

FROM base as final

COPY --from=publish /publish .