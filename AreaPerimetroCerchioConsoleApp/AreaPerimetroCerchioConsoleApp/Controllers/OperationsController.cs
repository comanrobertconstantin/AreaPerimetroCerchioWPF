using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AreaPerimetroCerchioConsoleApp.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OperationsController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public double GetArea(double raggio)
        {
            return raggio * raggio * Math.PI; ;
        }

        // GET: api/<controller>
        [HttpGet]
        public double GetPerimeter(double raggio)
        {
            return raggio * 2 * Math.PI; ;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
