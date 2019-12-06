using csharp_mongodb.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace csharp_mongodb.DbModels
{
    public class Context
    {
        private IMongoDatabase _database = null;

        public Context(IOptions<Settings> settings)
        {
            
            var client = new MongoClient(settings.Value.ConnectionString);

            if(client != null)
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Subscriber> Subscribers
        {
            get
            {
                return _database.GetCollection<Subscriber>("Subscriber");
            }
        }

    }
}