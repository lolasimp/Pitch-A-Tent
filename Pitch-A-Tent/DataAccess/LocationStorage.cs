using Pitch_A_Tent.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace Pitch_A_Tent.DataAccess
{
    public class LocationStorage
    {

        private const string ConnectionString = "Server = (local); Database=Pitch; Trusted_Connection=True";

        public IEnumerable<Locations> GetAllLocations()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<Locations>(@"select *
                                                        from locations");

                return result;
            }
        }

        public IEnumerable<Locations> GetSingleLocation(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<Locations>(@"select *
                                                        from locations as l
                                                        where l.id = @id", new { id = id});

                return result;
            }
        }


        public bool AddLocation(Locations location)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result2 = connection.Execute(@"Insert into [dbo].[locations]([name], [city], [state], [description], [img], [latLong], [hourOfOperation])
                                                 VALUES (@name, @city,  @state, @description, @img, @latLong, @hourOfOperation)", location);

                return result2 == 1;
            }
        }

        public bool UpdateLocation(int id, Locations location)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result = connection.Execute(@"UPDATE [dbo].[locations]
                                 SET [name] = @name, [city] = @city, [state] = @state, [description] = @description, [latLong] = @latLong, [hourOfOperation] = @hourOfOperation
                                 WHERE locations.id = @id", 
                                 new {
                                     name = location.name,
                                     city = location.city,
                                     state = location.state,
                                     description = location.description,
                                     latLong = location.latLong,
                                     hourOfOperation = location.hourOfOperation
                                 });

                return result == 1;
            }
        }

          public bool DeleteLocation(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
               connection.Open();

                var resultz = connection.Execute(@"DELETE FROM [dbo].locations WHERE id = @Id", new { id });

                return resultz == 1;
            }
        }
    }
}


//id 
//campingTypeId
// reveiewId 
// name 
//state 
// description 
// img
// glamping 
// backcountry 
// modern_camping 
// latLong 
// parkCode
//hourOfOperation 