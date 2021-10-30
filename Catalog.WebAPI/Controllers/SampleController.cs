using Catalog.Core.Entities;
using Catalog.Repository.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalog.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IMongoRepository<Customer> _customerRepository;

        public SampleController(IMongoRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/<SampleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var customers = _customerRepository.FilterBy(filter => filter.FirstName.ToLowerInvariant() != "test", projection => projection.FirstName);
            return customers;
        }

        // GET api/<SampleController>/5
        [HttpGet("{id}")]
        public async Task<string> Get(string id)
        {

            return (await _customerRepository.FindByIdAsync(id))?.FirstName;
        }

        // POST api/<SampleController>
        [HttpPost]
        public async Task Post(string firstName, string lastName, DateTime birthDate)
        {
            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };

            await _customerRepository.InsertOneAsync(customer);
        }

        // PUT api/<SampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
