FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /app

COPY *.csproj .
RUN dotnet restore 
COPY . .
RUN dotnet publish UdemyDockerizeAspNetCoreMvc.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /app/out .
ENV ASPNETCORE_URLS="http://*:4500"
ENV MySqlCon = "Uzak sunucu veritabani yolu"
ENTRYPOINT ["dotnet", "UdemyDockerizeAspNetCoreMvc.dll"]