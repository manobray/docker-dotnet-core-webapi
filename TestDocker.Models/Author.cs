using MongoDB.Bson;

namespace TestDocker.Models
{
    public class Author
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
    }
}
