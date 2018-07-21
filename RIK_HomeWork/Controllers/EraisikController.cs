using RIK_HomeWork.DataAccess;
using RIK_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RIK_HomeWork.Controllers
{
    public class EraisikController : ApiController
    {
        // GET: api/Eraisik
        public IEnumerable<Eraisik> Get()
        {
            List<Eraisik> Eraisikud = new List<Eraisik>();
            GetAccess db = new GetAccess();
            Eraisikud = db.GetEraisikud(null);
            return Eraisikud;
        }

        // GET: api/Eraisik/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Eraisik
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Eraisik/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Eraisik/5
        public void Delete(int id)
        {
        }
    }
}
