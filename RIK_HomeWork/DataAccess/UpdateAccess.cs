using Dapper;
using RIK_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RIK_HomeWork.DataAccess
{
    public class UpdateAccess
    {
        public void UpdateEraisik(Eraisik eraisik)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                connection.Execute("dbo.Eraisik_Update @Id, @Eesnimi, @Perekonnanimi, @Isikukood, @Makseviis, @Lisainfo", eraisik);
            }
        }

        public void UpdateJurIsik(JurIsik jurIsik)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                connection.Execute("dbo.Jurisik_Update @Id, @Jurnimi, @Firmakood, @Makseviis, @Lisainfo", jurIsik);
            }
        }
    }
}