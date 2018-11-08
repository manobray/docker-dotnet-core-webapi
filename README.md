# .Net Core Web Api with Docker
Simple WebApi self contained in a Docker container.

## How to build it:
1. Navigate to the `\TestDocker` folder.
2. Run both commmands:

```docker build -t {your-tag} .```

```docker run -d -p 8080:80 --name myapp {your-tag}```

## How to check it:
Running on http://localhost:8080/api/hello 

(or http://192.168.99.100:8080/api/hello if you're using Docker Toolbox)

It must return `Hello from .NET Core`.

## How to test it:
1. Install [enqueuer](https://github.com/lopidio/enqueuer)
2. Navigate to `\test` folder
3. Run

```nqr enqueuerConfig.yml```


