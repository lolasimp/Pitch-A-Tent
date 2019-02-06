using Pitch_A_Tent.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Pitch_A_Tent.DataAccess
{
    public class UsersStorage
    {
        private const string ConnectionString = "Server = (local); Database=Pitch; Trusted_Connection=True";

        public IEnumerable<User> GetAllUsers()
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<User>(@"select *
                                                    from users");

                return result;
            }
        }

        public IEnumerable<User> GetSingleUser(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<User>(@"select *
                                                    from users as u
                                                    where u.id = @id", new { id = id });

                return result;
            }
        }
    }
}
