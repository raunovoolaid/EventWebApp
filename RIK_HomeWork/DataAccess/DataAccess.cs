using Dapper;
using RIK_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RIK_HomeWork.DataAccess
{
    public class DataAccess
    {
        public List<Yritus> GetYritused()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                var output = connection.Query<Yritus>("dbo.Yritus_Select").ToList();
                return output;
            }
        }
        public List<Eraisik> GetEraisikud()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                var output = connection.Query<Eraisik>("dbo.Eraisik_Select").ToList();
                return output;
            }
        }
        public List<JurIsik> GetJurIsikud()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                var output = connection.Query<JurIsik>("dbo.Jurisik_Select").ToList();
                return output;
            }
        }

    }
}