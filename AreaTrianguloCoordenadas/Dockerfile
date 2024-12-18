# Usa la imagen base de .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Establece el directorio de trabajo en el contenedor
WORKDIR /app

# Crea un nuevo proyecto .NET
RUN dotnet new console -o App -n areaTriangulo

# Copia el archivo Program.cs desde la máquina local al contenedor
COPY Program.cs /app/App/Program.cs

# Cambia al directorio de la aplicación
WORKDIR /app/App

# Publica la aplicación en modo Release
RUN dotnet publish -c Release -o /app/publish

# Usa una imagen más ligera para el runtime (opcional pero recomendado para producción)
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Establece el directorio de trabajo en el contenedor final
WORKDIR /app

# Copia los archivos publicados desde la etapa de construcción
COPY --from=build /app/publish .

# Define el comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "areaTriangulo.dll"]

# Define el comando para ejecutar el shell
CMD ["/bin/bash"]