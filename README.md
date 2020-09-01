# dotnet-image-docker
This repository represents a docker image with a simple code .net core C#

Before you commit chages, you need generate deploy to docker hub get dll and include into image container.

For this, execute at project folder:

`
docker publish -c Release -o deploy
`

- -c : represents configuration, that case "Release"
 - -o : represents output folder

 After dotnet compile, it generate some files, for example a assembly file: dotnet-image-docker.dll

# Start Container
