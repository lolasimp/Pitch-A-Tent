using Dapper;
using Pitch_A_Tent.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.DataAccess
{
    public class CampTypeStorage
    {
        private const string ConnectionString= "Server = (local); Database=Pitch; Trusted_Connection=True";

        public IEnumerable<CampingType> GetAllCampsites()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<CampingType>(@"select * from campingType");

                return result;
            }
        }
    }
}
