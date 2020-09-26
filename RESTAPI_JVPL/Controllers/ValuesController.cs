using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using RESTAPI_JVPL.Models;

namespace RESTAPI_JVPL.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {

            return new string[] { "Jose Vidal Panameño Lizano", "35-4436-2011" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            Alumno p2 = new Alumno
            {
                Id=id,
                Nombre = "Product 2",
                Carnet = "3544362011",
            };

            List<Alumno> alumno = new List<Alumno>();
            alumno.Add(p2);

            string json = JsonConvert.SerializeObject(alumno, Formatting.Indented);

            return json;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
