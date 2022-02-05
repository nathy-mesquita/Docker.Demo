FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine

COPY bin/Release/net6.0/publish App/

WORKDIR /App

ENTRYPOINT [ "dotnet", "Docker.Demo.dll" ]
