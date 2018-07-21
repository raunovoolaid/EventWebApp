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
    public class JurIsikController : ApiController
    {
        // GET: api/JurIsik
        //public IEnumerable<JurIsik> Get()
        //{
        //    List<JurIsik> JurIsikud = new List<JurIsik>();
        //    GetAccess db = new GetAccess();
        //    JurIsikud = db.GetJurIsikud(null);
        //    return JurIsikud;
        //}

        // GET: api/JurIsik/5
        public IEnumerable<JurIsik> Get(int? id = null)
        {
            List<JurIsik> JurIsikud = new List<JurIsik>();
            GetAccess db = new GetAccess();
            JurIsikud = db.GetJurIsikud(id);
            return JurIsikud;
        }

        // POST: api/JurIsik
        public void Post(JurIsik jurIsik) {
            InsertAccess db = new InsertAccess();
            db.InsertJurIsik(jurIsik);
        }

        // PUT: api/JurIsik/5
        public void Put(JurIsik jurisik/*int id, string jurnimi, string firmakood, int makseviis, string lisainfo*/)
        {
            UpdateAccess db = new UpdateAccess();
            db.UpdateJurIsik(jurisik);
        }

        // DELETE: api/JurIsik/5
        public void Delete(int id)
        {
            DeleteAccess db = new DeleteAccess();
            db.DeleteJurIsik(id);
        }
    }
}
