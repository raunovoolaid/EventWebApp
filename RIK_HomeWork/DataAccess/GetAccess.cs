using Dapper;
using RIK_HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RIK_HomeWork.DataAccess
{
    public class GetAccess
    {
        public List<Yritus> GetYritused(int? id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                var output = connection.Query<Yritus>("dbo.Yritus_Select @Id", new { Id = id}).ToList();
                return output;
            }
        }
        public List<Eraisik> GetEraisikud(int? id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                var output = connection.Query<Eraisik>("dbo.Eraisik_Select @Id", new { Id=id }).ToList();
                return output;
            }
        }
        public List<JurIsik> GetJurIsikud(int? id, int? yritus_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("Events")))
            {
                var output = connection.Query<JurIsik>("dbo.Jurisik_Select @Id @Yritus_id", new { Id = id , Yritus_id = yritus_id}).ToList();
                return output;
            }
        }

    }
}