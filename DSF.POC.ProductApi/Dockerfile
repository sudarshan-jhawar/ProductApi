#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DSF.POC.ProductApi/DSF.POC.ProductApi.csproj", "DSF.POC.ProductApi/"]
RUN dotnet restore "DSF.POC.ProductApi/DSF.POC.ProductApi.csproj"
COPY . .
WORKDIR "/src/DSF.POC.ProductApi"
RUN dotnet build "DSF.POC.ProductApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DSF.POC.ProductApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DSF.POC.ProductApi.dll"]