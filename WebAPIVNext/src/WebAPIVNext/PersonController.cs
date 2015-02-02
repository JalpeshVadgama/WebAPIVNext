using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;


namespace WebAPIVNext.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
		static List<Person> person = new List<Person>
		{
			[1]= new Person { PersonId=1,FirstName="Jalpesh",LastName="Vadgama"},
			[2]= new Person { PersonId=2, FirstName="Vishal",LastName="Vadgama"}
		};

        // GET: api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
			return person;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
			var currentPerson = person.FirstOrDefault(p => p.PersonId == id);
			return currentPerson;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
