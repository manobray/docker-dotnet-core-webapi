using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Linq;
using TestDocker.Models;

namespace TestDocker.DAL
{
    public class AuthorsRepository
    {
        public string First()
        {
            MongoClient client = new MongoClient(AppModel.DataBaseStrings.ConexaoMongoDb);
            IMongoDatabase db = client.GetDatabase("docker-test");

            var authorCollection = db.GetCollection<Author>("authors");
            var autores = authorCollection.Find(_ => true);
            return autores.FirstOrDefault().Name;
        }
    }
}
