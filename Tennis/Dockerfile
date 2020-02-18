FROM mcr.microsoft.com/dotnet/core/sdk:1.1 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet build
#RUN dotnet publish -c Release -o out

# run the unit tests
FROM build-env as test
# set the directory to be within the unit test project
WORKDIR /app
# run the unit tests
RUN dotnet test --logger:trx
#RUN dotnet test --logger:trx && cat TestResults/*.trx

# Build runtime image
#FROM mcr.microsoft.com/dotnet/core/aspnet:1.1
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "aspnetapp.dll"]
