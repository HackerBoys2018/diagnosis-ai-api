using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OptumBots.Controllers
{
    public class ValuesController : ApiController
    {

        // GET api/values
        OptumAIEntities1 en = new OptumAIEntities1();

        public IEnumerable<string> Get()
        {
            var ex = from disease in en.Diseases
                     select disease.Name;
            return ex;
        }

        // GET api/values/5
        public string Get(string cause, [FromBody] Symptom sym )
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]Patient value)
        {
            en.Patients.Add(value);
            en.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
