#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WebAPI02.csproj", "/src"]
RUN dotnet restore "WebAPI02.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "WebAPI02.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish  -c Release -r linux-x64  -o /app/publish  -p:PublishReadyToRun=true -p:PublishTrimmed=true 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPI02.dll"]