﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalog.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        // GET: api/<CatalogController>
        [HttpGet]
        public IEnumerable<string> GetProducts()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CatalogController>/5
        [HttpGet("{id}")]
        public string GetProduct(string id)
        {
            return "value";
        }

        // GET api/v1/G
        [HttpGet("category/{category}")]
        public string GetProductByCategory(string category)
        {
            return "value";
        }


        // POST api/<CatalogController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CatalogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CatalogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
