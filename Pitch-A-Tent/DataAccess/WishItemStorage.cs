﻿using Dapper;
using Pitch_A_Tent.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.DataAccess
{
    public class WishItemStorage
    {
    private const string ConnectionString = "Server = (local); Database=Pitch; Trusted_Connection=True";

    public IEnumerable<WishItem> GetAllWishItems()
    {
        using (var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            var result = connection.Query<WishItem>(@"select i.user_id, i.location_id, l.campingTypeId, l.description, i.id
                                                    from wishItem as i
                                                    join locations as l on i.location_id = l.id");

            return result;
        }
    }

        public IEnumerable<WishItem> GetWishItemByUserId(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<WishItem>(@"select i.user_id, i.location_id, l.campingTypeId, l.name, l.description, i.id
                                                        from wishItem as i
                                                        join locations as l on i.location_id = l.id
                                                        where user_id = @id", new { id = id });

                return result;
            }
        }


        //WISH MODEL
        //user_id 
        //location_id 
        //campType_id 
        //description 
        //id 


        //public bool AddNewWishItem(WishItem wishItem)
        //{
        //    using (var connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();

        //        var result3 = connection.Execute(@"INSERT INTO [dbo].[wishItem]
        //                                        ([User_id],
        //                                        [Location_id]
        //                                        [CampingTypeId]
        //                                        [Description])
        //                                        VALUES (@User_id, @Location_id, @CampingTypeId, @Description)", wishItem
        //                                        );

        //        return result3 == 1;
        //    }
        //}


        public WishItem AddNewWishItem(WishItem wishItem)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var wishObject = new
                {
                    User_id = wishItem.User_id,
                    Location_id = wishItem.Location_id,
                    CampingTypeId = wishItem.CampingTypeId,
                    Description = wishItem.Description
                };

                var command = @"
                                DECLARE @inserted TABLE (User_id int, Location_id int, CampingTypeId int, Description string, Id int);
                                INSERT INTO wishItem (User_id, Location_id, CampingTypeId, Description)
                                OUTPUT INSERTED.Id, INSERTED.User_id, INSERTED.Location_id, INSERTED.CampingTypeId, INSERTED.Description
                                INTO @inserted
                                VALUES(@User_id, @Location_id, @CampingTypeId, @Description)
                                SELECT * FROM @inserted";

                return connection.QueryFirstOrDefault<WishItem>(command, wishObject);
            }
        }

        public bool DeleteWishItem(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var result = db.Execute(@"DELETE FROM [dbo].wishItem WHERE id = @Id", new { id });
                return result == 1;
            }
        }
    }
}


