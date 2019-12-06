using System.Collections.Generic;
using System.Threading.Tasks;
using csharp_mongodb.Model;
using MongoDB.Driver;

namespace csharp_mongodb.IRepository
{
    public interface ISubscriberRepository
    {
        Task<IEnumerable<Subscriber>> GetAsync();
        Task<Subscriber> Get(string id);
        Task Add(Subscriber subscriber);
        Task<string> Update(string id, Subscriber subscriber);
        Task<DeleteResult> Remove(string id);
        Task<DeleteResult> RemoveAll();

    }
}
