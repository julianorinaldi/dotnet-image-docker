FROM mcr.microsoft.com/dotnet/core/runtime:latest

LABEL "Maintainer"="julianorinaldi"

COPY deploy/ /home/deploy

WORKDIR /home/deploy

ENTRYPOINT ["dotnet", "dotnet-image-docker.dll"]



