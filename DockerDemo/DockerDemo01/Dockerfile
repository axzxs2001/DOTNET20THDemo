
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DockerDemo01.csproj", "/src"]
RUN dotnet restore "DockerDemo01.csproj"
COPY . .

WORKDIR "/src"
RUN dotnet build "DockerDemo01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerDemo01.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerDemo01.dll"]