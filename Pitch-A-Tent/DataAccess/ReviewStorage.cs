using Dapper;
using Pitch_A_Tent.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Pitch_A_Tent.DataAccess
{
    public class ReviewStorage
    {
        private const string ConnectionString = "Server = (local); Database=Pitch; Trusted_Connection=True";

        public IEnumerable<Review> GetAllReviews()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<Review>(@"select *
                                                      from reviews");
                return result;
            }
        }


        public IEnumerable<Review> GetReviewByLocationId(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result2 = connection.Query<Review>(@"select * from reviews where location_id = @id", new { id = id });

                return result2;
            }
        }

        //id
        //user_id
        //location_id
        //rating
        //comment

        public bool AddReview(Review review)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result2 = connection.Execute(@"Insert into [dbo].[reviews]([user_id], [location_id], [rating], [comment])
                                                 VALUES (@user_id,  @location_id, @rating, @comment)", review);

                return result2 == 1;
            }
        }

        public bool UpdateReview(int id, Review review)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result = connection.Execute(@"UPDATE [dbo].[reviews]
                                 SET [user_id] = @user_id,  [location_id] = @location_id, [rating] = @rating, [comment] = @comment
                                 WHERE reviews.id = @id",
                                 new
                                 {
                                     name = review.user_id,
                                     city = review.location_id,
                                     state = review.rating,
                                     description = review.comment,
                                     id = review.id
                                 });

                return result == 1;
            }
        }


        public bool DeleteReview(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var result = db.Execute(@"DELETE FROM [dbo].reviews WHERE id = @Id", new { id });
                return result == 1;
            }
        }
    }
}

