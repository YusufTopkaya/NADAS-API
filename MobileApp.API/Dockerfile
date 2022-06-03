#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src


# First copy the solution file, if you have a nuget config copy it here as well
COPY *.sln .

# Then copy the source projects, they all get put into the same folder
COPY src/*/*.csproj .
# This line then moves the project files to the correct folders
RUN for file in $(ls *.csproj); do mkdir -p src/${file%.*}/ && mv $file src/${file%.*}/; done

RUN dotnet restore

COPY . .

# We can now build everything, but we don't need to restore, so tell dotnet to skip that
RUN dotnet build -c Release --no-restore

# And then we can test, but this time we don't build, as we've alredy done that
# You can just do a test instead of build then test, but I've found diagnosing issues easier this way
RUN dotnet test -c Release --no-restore --no-build

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Nadas.API.dll"]