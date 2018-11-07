# .Net Core Web Api with Docker
Simple WebApi self contained in a Docker container.

## How to build it:
1 - Open PowerShell or CMD and navigate to the TestDocker folder.

2 - Run both commmands:

```docker build -t {your-tag} .```

```docker run -d -p 8080:80 --name myapp {your-tag}```

## How to test it:
Running on http://localhost:8080/api/hello 
or http://192.168.99.100:8080/api/hello if using Docker Toolbox

It must return `Hello from .NET Core`.
