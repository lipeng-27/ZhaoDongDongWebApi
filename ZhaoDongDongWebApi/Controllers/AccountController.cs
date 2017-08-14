using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc.Html;

namespace ZhaoDongDongWebApi.Controllers
{
    public class AccountController : ApiController
    {
        // GET: api/Account
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Account/5
        public string Validate(int id)
        {
            return "value";
        }

        // POST: api/Account
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Account/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Account/5
        public void Delete(int id)
        {
        }

        [AcceptVerbs("GET", "POST")]
        [HttpGet]
        public bool AccountValidation(string name, string password)
        {
            if(name=="philip" && password=="123456")
                return true;
            if (name == "rythm" && password == "123456")
                return true;
            return false;
        }
    }
}
