# docker-dotnet-core-webapi
Simple WebApi self contained in a Docker container.

#h2 How to build it:
Simply run:
docker build -t {your-tag} .
docker run -d -p 8080:80 --name myapp {your-tag}

#h2 How to test it:
Open your browser at:
http://localhost:8080/api/hello
