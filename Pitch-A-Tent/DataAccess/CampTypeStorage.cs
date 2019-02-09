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

        public IEnumerable<CampingType> GetAllCampsiteTypes()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<CampingType>(@"select *
                                                            from campingType");

                return result;
            }
        }

        public IEnumerable<CampingType> GetCampsiteTypeById(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var result = connection.Query<CampingType>(@"select *
                                                            from campingType as c
                                                            where c.id = @id", new { id = id });

                return result;
            }
        }

        //public bool AddCampType(CampingType campsite)
        //{
        //    using (var connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();

        //        var result = connection.Execute(@"insert into [dbo].[campingType], ([accessRoad], [backcountry], [campStore], 
        //                                        [cell_phone_reception], [dumpStation], [electricalHookUp],
        //                                        [fireStovePolicy], [firewood_for_sale], [food_storage_locker],
        //                                        [glamping], [internetConnectivity], [laundry], 
        //                                        [modern_camping], [potableWater], [rvOnly],
        //                                        [showers], [staffOnSite], [state_nationl_park],
        //                                        [tent_only], [tent_only], [toilets])
        //                                        values(@id, @accessRoad, @backcountry, @campStore, 
        //                                        @cell_phone_reception, @dumpStation, @electricalHookUp,
        //                                        @fireStovePolicy, @firewood_for_sale, @food_storage_locker,
        //                                        @glamping, @internetConnectivity, @laundry, 
        //                                        @modern_camping, @potableWater, @rvOnly,
        //                                        @showers, @staffOnSite, @state_nationl_park,
        //                                        @tent_only, @tent_only, @toilets)", campsite);

        //        return result == 1;
        //    }
        //}




        public bool DeleteCampingType(int id)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Open();
                var result = db.Execute(@"DELETE FROM [dbo].campingType WHERE id = @Id", new { id });
                return result == 1;
            }
        }
    }
}
