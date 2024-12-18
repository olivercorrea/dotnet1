FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

RUN dotnet new webapi -o MyMicroservice --no-https

# El copy es opcional, recien añadido
COPY Program.cs /app/MyMicroservice/Program.cs

WORKDIR /app/MyMicroservice

# esto puede ser opcional
RUN dotnet restore

RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "MyMicroservice.dll"]

# Define el comando para ejecutar el shell
CMD ["/bin/bash"]

