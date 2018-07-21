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
    public class YritusController : ApiController
    {
        // GET: api/Yritus
        //public IEnumerable<Yritus> Get()
        //{
        //    List<Yritus> Yritused = new List<Yritus>();
        //    GetAccess db = new GetAccess();
        //    Yritused = db.GetYritused(null);
        //    return Yritused;
        //}

        // GET: api/Yritus/5
        public IEnumerable<Yritus> Get(int? Id=null)
        {
            List<Yritus> Yritused = new List<Yritus>();
            GetAccess db = new GetAccess();
            Yritused = db.GetYritused(Id);
            return Yritused;
        }

        // POST: api/Yritus
        public void Post(Yritus yritus)
        {
            InsertAccess db = new InsertAccess();
            db.InsertYritus(yritus);
        }

        // PUT: api/Yritus/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Yritus/5
        public void Delete(int id)
        {
        }
    }
}
