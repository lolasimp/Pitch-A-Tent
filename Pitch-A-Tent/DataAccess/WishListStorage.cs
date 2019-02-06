using Dapper;
using Pitch_A_Tent.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.DataAccess
{
    public class WishListStorage
    {
    private const string ConnectionString = "Server = (local); Database=Pitch; Trusted_Connection=True";

    public IEnumerable<WishLists> GetAllWishLists()
    {
        using (var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            var result = connection.Query<WishLists>(@"select *
                                                            from wishLists");

            return result;
        }
    }

    public IEnumerable<WishLists> GetWishListByUserId(int id)
    {
        using (var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            var result = connection.Query<WishLists>(@"select *
                                                            from wishLists as w
                                                            where user_id = @id", new { id = id });

            return result;
        }
    }


        public bool AddNewWishList(WishLists wish)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result = connection.Execute(
                        @"insert into [dbo].[wishLists]([user_id], [name], [description])
                        VALUES (@user_id, @name, @description", wish);

                return result == 1;
            }
        }

        public bool UpdateWish(WishLists wish, int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var result = db.Execute(@"UPDATE [dbo].[wishLists]
                                        SET [name] = @name, [description] = @description
                                        where id = @id",
                                        new {
                                            id,
                                            user_id = wish.user_id,
                                            name = wish.name,
                                            description = wish.description,
                                            }
                                        );
                return result == 1;
            }
        }
    }
}
