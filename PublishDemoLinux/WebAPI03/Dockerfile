
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WebAPI03.csproj", "/src"]
RUN dotnet restore "WebAPI03.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "WebAPI03.csproj" -c Release -o /app/build 

FROM build AS publish
RUN dotnet publish -r linux-x64 -c Release  -o /app/publish -p:PublishTrimmed=true -p:CppCompilerAndLinker=clang -p:SysRoot=/crossrootfs/x64


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPI03.dll"]