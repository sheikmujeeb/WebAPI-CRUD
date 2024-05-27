using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using CRUD_WebAPIclasslibrary;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_CRUD.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BusDetailsController : ControllerBase
    {
        
        BusRepos newreg;
        public BusDetailsController()
            {
            newreg =new BusRepos();
            }
        // GET: api/<BusDetailsController>
        [HttpGet]
        public IEnumerable<Busdetails> Get()
        {
            return newreg.SPselectall();
        }

        // GET api/<BusDetailsController>/5
        [HttpGet("{name}")]
        public IEnumerable<Busdetails> Get(string name)
        {
            return newreg.SPsearch(name);
        }

        // POST api/<BusDetailsController>
        [HttpPost]
        public void Post([FromBody] Busdetails reg)
        {
            newreg.SPlogin(reg);
        }

        // PUT api/<BusDetailsController>/5
        [HttpPut("{id}")]
        public void Put( int id,[FromBody] string start, string end, int far, int ticket)
        {
            newreg.SPupdate(id,start,end,far,ticket);
        }

        // DELETE api/<BusDetailsController>/5
        [HttpDelete("{busname}")]
        public void Delete(string busname)
        {
            newreg.SPremove(busname);
        }
    }
}
