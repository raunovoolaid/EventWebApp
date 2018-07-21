using Dapper;
using RIK_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RIK_HomeWork.DataAccess
{
    public class InsertAccess
    {
        public void InsertEraisik(Eraisik eraisik)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                connection.Execute("dbo.Eraisik_Insert @Yritus_id, @Eesnimi, @Perekonnanimi, @Isikukood, @Makseviis, @Lisainfo", eraisik);
            }
        }
        public void InsertYritus(Yritus yritus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                connection.Execute("dbo.Event_Insert @Yritus_nimi, @Kuupaev, @Asukoht, @Lisainfo", yritus);
            }
        }

    }
}