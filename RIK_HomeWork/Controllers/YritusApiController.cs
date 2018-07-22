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
    public class YritusApiController : ApiController
    {
        
        // GET: api/Yritus/5
        public List<Yritus> Get(int? Id=null)
        {
            List<Yritus> Yritused = new List<Yritus>();
            GetAccess db = new GetAccess();
            Yritused = db.GetYritused(Id);
            return Yritused;
        }

        // POST: api/Yritus
        public void Post(Yritus yritus)
        {
            if(yritus.Kuupaev > DateTime.Now)
            {
                InsertAccess db = new InsertAccess();
                db.InsertYritus(yritus);
            }
        }
    
        // DELETE: api/Yritus/5
        public void Delete(int id)
        {
            DeleteAccess db = new DeleteAccess();
            db.DeleteYritus(id);
        }
    }
}
