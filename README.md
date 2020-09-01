# Information
This repository represents a docker image with a simple code .net core C#

You can get image container on: 

https://hub.docker.com/r/julianorinaldi/dotnet-image-docker

# How to prepare package to create image container
Before you commit changes, you need generate deploy to docker hub get dll and include into image container.

For this, execute at project folder:

`
docker publish -c Release -o deploy
`

- -c : represents configuration, that case "Release"
 - -o : represents output folder

 After dotnet compile, it generate some files, for example a assembly file: 
 
 dotnet-image-docker.dll

# Start Container
If you want running the container example, you need exec the command below:

`
docker run -itd --name my-container-dotnet julianorinaldi/dotnet-image-docker
`

If you haven't image on your PC, it's automatically will download.

# Verify Running
- For verify if your container is running, you can exec:

`
docker ps
`

- Verifing the output that you container

`
docker logs -tf my-container-dotnet
`

If is running, you can see similar image below

:::image type="content" source="images/output-hello-world.png" alt-text="Output":::

