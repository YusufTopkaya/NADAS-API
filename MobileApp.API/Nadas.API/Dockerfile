#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Nadas.API/Nadas.API.csproj", "Nadas.API/"]
COPY ["Nadas.DTO/Nadas.API.DTO.csproj", "Nadas.DTO/"]
COPY ["Nadas.API.Entities/Nadas.API.Entities.csproj", "Nadas.API.Entities/"]
COPY ["Nadas.API.Domain/Nadas.API.Domain.csproj", "Nadas.API.Domain/"]
COPY ["Nadas.API.Business/Nadas.API.Business.csproj", "Nadas.API.Business/"]
COPY ["Nadas.API.DataAccess/Nadas.API.DataAccess.csproj", "Nadas.API.DataAccess/"]
RUN dotnet restore "Nadas.API/Nadas.API.csproj"
COPY . .
WORKDIR "/src/Nadas.API"
RUN dotnet build "Nadas.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Nadas.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nadas.API.dll"]
