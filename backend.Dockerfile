FROM mcr.microsoft.com/dotnet/aspnet:6.0 as base

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

COPY . .

RUN dotnet restore "Server/BarabanWebAPI/BarabanWebAPI.csproj"
RUN dotnet restore "Server/CalcMicroservices/CalcMicroservice.csproj"
RUN dotnet restore "Server/ReportMicroservice/ReportMicroservice.csproj"

RUN dotnet build "Server/BarabanWebAPI/BarabanWebAPI.csproj" -o /build
RUN dotnet build "Server/CalcMicroservices/CalcMicroservice.csproj" -o /build
RUN dotnet build "Server/ReportMicroservice/ReportMicroservice.csproj" -o /build

FROM build as publish
RUN dotnet publish "Server/BarabanWebAPI/BarabanWebAPI.csproj" -o /publish
RUN dotnet publish "Server/CalcMicroservices/CalcMicroservice.csproj" -o /publish
RUN dotnet publish "Server/ReportMicroservice/ReportMicroservice.csproj" -o /publish

FROM base as final

COPY --from=publish /publish .