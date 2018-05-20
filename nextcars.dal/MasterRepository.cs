using nextcars.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace nextcars.dal
{
    public class MasterRepository : BaseRepository
    {
        static string dataConnection = GetConnectionString("conString");

        public int SaveCarVideo(CarVideos model)
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string sql = @"INSERT INTO CarVideos(carId, vidURL, vidCourtsy, vidDescription, vidTypeId, createDate) 
                values(@CrId, @vidURL, @vidCourtsy, @vidDescription, @vidTypeId, @createDate)";
                model.createDate = DateTime.Now;
                int rowsAffected = connection.Execute(sql, model);
                return rowsAffected;
            }
        }
        public int SaveCarDiamention(CarDiamention model)
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string sql = @"INSERT INTO CarDiamention(
                carId
                ,Length
                ,Width
                ,Height
                ,WheelBase
                ,GroundClerance
                ,FrontTrack
                ,RearTrack
                ,FuelTank)
                VALUES(
                @carId
                ,@Length
                ,@Width
                ,@Height
                ,@WheelBase
                ,@GroundClerance
                ,@FrontTrack
                ,@RearTrack
                ,@FuelTank)";

                int rowsAffected = connection.Execute(sql, model);
                return rowsAffected;
            }
        }
    }
}
