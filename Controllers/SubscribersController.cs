using System.Collections.Generic;
using System.Threading.Tasks;
using csharp_mongodb.IRepository;
using csharp_mongodb.Model;
using Microsoft.AspNetCore.Mvc;

namespace csharp_mongodb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController : ControllerBase
    {

        private readonly ISubscriberRepository _subscriberRepository;

        public SubscribersController(ISubscriberRepository subscriberRepository)
        {
            _subscriberRepository = subscriberRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Subscriber>> GetAsync()
        {
            return await _subscriberRepository.GetAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<Subscriber> Get(string id)
        {
            return await _subscriberRepository.Get(id);
        }

        [HttpPost]
        public async Task<Subscriber> Add(Subscriber sub)
        {
            await _subscriberRepository.Add(sub);
            return sub;
        }


    }
}