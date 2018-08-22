using Dapper;
using RIK_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RIK_HomeWork.DataAccess
{
    public class DeleteAccess
    {
        public void DeleteYritus(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                connection.Execute("dbo.Yritus_Delete @Id", new { Id = id });
            }
        }

        public void DeleteJurIsik(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                connection.Execute("dbo.JurIsik_Delete @Id", new { Id = id });
            }
        }
        public void DeleteEraisik(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                connection.Execute("dbo.EraIsik_Delete @Id", new { Id = id });
            }
        }
    }
}