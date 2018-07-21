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
        //public IEnumerable<Eraisik> Get()
        //{
        //    List<Eraisik> Eraisikud = new List<Eraisik>();
        //    GetAccess db = new GetAccess();
        //    Eraisikud = db.GetEraisikud(null);
        //    return Eraisikud;
        //}

        // GET: api/Eraisik/5
        public IEnumerable<Eraisik> Get(int? id = null)
        {
            List<Eraisik> Eraisikud = new List<Eraisik>();
            GetAccess db = new GetAccess();
            Eraisikud = db.GetEraisikud(id);
            return Eraisikud;
        }

        // POST: api/Eraisik
        public void Post(Eraisik eraisik)
        {
            InsertAccess db = new InsertAccess();
            db.InsertEraisik(eraisik);
        }

        // PUT: api/Eraisik/5
        [HttpPut]
        public void Put(Eraisik eraisik)
        {
            UpdateAccess db = new UpdateAccess();
            db.UpdateEraisik(eraisik);
        }

        // DELETE: api/Eraisik/5
        public void Delete(int id)
        {
        }
    }
}
