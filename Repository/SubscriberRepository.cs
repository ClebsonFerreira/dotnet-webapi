using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using csharp_mongodb.DbModels;
using csharp_mongodb.IRepository;
using csharp_mongodb.Model;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace csharp_mongodb.Repository
{
    public class SubscriberRepository : ISubscriberRepository
    {
        private readonly Context _context = null;

        public SubscriberRepository(IOptions<Settings> settings)
        {
            _context = new Context(settings);
        }

        public async Task Add(Subscriber subscriber)
        {
            await _context.Subscribers.InsertOneAsync(subscriber);
        }

        public async Task<IEnumerable<Subscriber>> GetAsync()
        {
            return await _context.Subscribers.Find(x => true).ToListAsync();
        }

        public async Task<Subscriber> Get(string id)
        {
            //  var subscriber = Builders<Subscriber>.Filter.Eq("_id", id);
            return await _context.Subscribers.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<DeleteResult> Remove(string id)
        {
            // var subscriber = _context.Subscribers.Find(x => x.Id == id).FirstOrDefaultAsync();
            return await _context.Subscribers.DeleteOneAsync(x => x.Id == id);
        }

        public async Task<DeleteResult> RemoveAll()
        {
            return await _context.Subscribers.DeleteManyAsync(new BsonDocument());
        }

        public async Task<string> Update(string id, Subscriber subscriber)
        {
            await _context.Subscribers.ReplaceOneAsync(xx => xx.Id == id, subscriber);
            return "";
        }
    }
}