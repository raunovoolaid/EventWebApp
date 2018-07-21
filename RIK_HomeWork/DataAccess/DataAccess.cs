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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Yritus>("dbo.Yritus_Select").ToList();
                return output;
            }
        }
    }
}