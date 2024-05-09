FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY . .

RUN dotnet restore "Server/ReportMicroservice/ReportMicroservice.csproj"

RUN dotnet build "Server/ReportMicroservice/ReportMicroservice.csproj" -o /build

FROM build as publish
RUN dotnet publish "Server/ReportMicroservice/ReportMicroservice.csproj" -o /publish

FROM base as final

COPY --from=publish /publish .