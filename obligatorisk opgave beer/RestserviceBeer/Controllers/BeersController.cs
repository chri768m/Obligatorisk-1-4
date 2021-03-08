using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using obligatorisk_opgave_beer;
using RestserviceBeer.Manager;

namespace RestserviceBeer.Controllers
{
    [Route("api/Beer")]
    [ApiController]
    public class BeersController : ControllerBase
    {
        private readonly BeerManager Manager = new BeerManager();
        // GET: api/Beers
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return Manager.Getall();
        }

        // GET: api/Beers/5
        [HttpGet("{id}", Name = "Get")]
        public Beer Get(int ID)
        {
            return Manager.GetById(ID);
        }

        // POST: api/Beers
        [HttpPost]
        public Beer Post([FromBody] Beer value)
        {
            return Manager.Add(value);
        }

        // PUT: api/Beers/5
        [HttpPut("{id}")]
        public Beer Put(int id, [FromBody] Beer value)
        {
            return Manager.Update(id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Beer Delete(int id)
        {
            return Manager.Delete(id);
        }

       
    }
}
