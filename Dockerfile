FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine

LABEL version="1.0.0" description="Disponibilizando API Docker Demo" maintainer="Nathaly Mesquita<nnathalygm@gmail.com>"

COPY bin/Release/net6.0/publish App/

WORKDIR /App

ENTRYPOINT [ "dotnet", "Docker.Demo.dll" ]
