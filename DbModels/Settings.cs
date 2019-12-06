using Microsoft.Extensions.Configuration;

namespace csharp_mongodb.DbModels
{
    public class Settings
    {
        public string ConnectionString;
        public string Database;
        public IConfigurationRoot IconfigurationRoot;
    }
}