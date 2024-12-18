#!/bin/bash

CONTAINER_ID=$(docker ps -q -f name=dotnet-area-triangulo-coordenadas)

if [ -n "$CONTAINER_ID" ]; then

  echo "Deteniendo contenedor existente..."

  docker stop $CONTAINER_ID

  docker rm $CONTAINER_ID

fi

docker build -t dotnet-area-triangulo-coordenadas .

docker run -it dotnet-area-triangulo-coordenadas /bin/bash

