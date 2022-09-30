# Dev Env

WSL2 with Ubuntu: 20.04

# Install Dotnet

```bash
sudo apt update; \
sudo apt install -y apt-transport-https && \
sudo apt update &&  \
sudo apt install -y dotnet-sdk-6.0
```

# Create App

```bash
mkdir -p HelloWorld
cd HelloWorld
```

The folder name becomes the project name and the namespace name by default.

```bash
dotnet new --list
dotnet new console --framework net6.0
dotnet new gitignore
```

Edit the `Program.cs` and run.

```bash
dotnet run
```

# Start MSSQL

```bash
docker compose up -d
```

# Connect to DB

```bash
dotnet add package Microsoft.Data.SqlClient
```

Edit the `Program.cs` and run. Note that the DataSource is `host.docker.internal`.

```bash
dotnet restore
dotnet run
```

Example output:
```
Determining projects to restore...
  All projects are up-to-date for restore.
Hellow World
Connection Status is Open
Server Version is 15.00.2000
Press Enter to Continue:
```

# TODO

## gRPC

`dotnet new --list`

These templates matched your input: 

```
Template Name              Short Name      Language    Tags                      
-------------------------  --------------  ----------  --------------------------
ASP.NET Core gRPC Service  grpc            [C#]        Web/gRPC                  
Protocol Buffer File       proto                       Web/gRPC                   
```