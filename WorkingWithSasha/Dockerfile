FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WorkingWithSasha/WorkingWithSasha.csproj", "WorkingWithSasha/"]
RUN dotnet restore "WorkingWithSasha/WorkingWithSasha.csproj"
COPY . .
WORKDIR "/src/WorkingWithSasha"
RUN dotnet build "WorkingWithSasha.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WorkingWithSasha.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WorkingWithSasha.dll"]
