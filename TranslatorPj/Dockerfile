FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Translator/Translator.csproj", "Translator/"]
RUN dotnet restore "Translator/Translator.csproj"
COPY . .
WORKDIR "/src/Translator"
RUN dotnet build "Translator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Translator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Translator.dll"]
