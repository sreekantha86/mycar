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
    public class HomeRepository:BaseRepository
    {
        static string dataConnection = GetConnectionString("conString");
        public List<Manufacture> GetManufactures()
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string query = String.Format(@"select
                                                mfId
                                                ,mfName
                                                ,mfShortName
                                                ,ctId
                                                ,mfStartYear
                                                ,mfDescription
                                                ,mfLink
                                                ,mfLogo
                                                ,isEnabled
                                                from Manufacturer
                                                where isEnabled = 1
                                                order by mfName");

                return connection.Query<Manufacture>(query).ToList();
            }
        }
        public List<BodyType> GetBodyTypes()
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string query = String.Format(@"select btId, btName from BodyType");

                return connection.Query<BodyType>(query).ToList();
            }
        }
        public List<Fuel> GetFuel()
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string query = String.Format(@"select fulId, fulName from Fuel");

                return connection.Query<Fuel>(query).ToList();
            }
        }
        public List<Hotlaunch> GetHotLaunch()
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string query = String.Format(@"select top 5 * from Hotlaunch order by hlId Desc");

                return connection.Query<Hotlaunch>(query).ToList();
            }
        }
        public List<VideoGallery> GetVideoGallery()
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string query = String.Format(@"select top 4 B.mfId, C.mfShortName, D.btId,D.btName,B.carName, A.vidURL, A.vidCourtsy,Replace(vidURL,'https://www.youtube.com/embed/','')VideoId
                from CarVideos A
                inner join Car B on A.carId = B.carId
                inner join Manufacturer C on B.mfId = C.mfId
                inner join BodyType D on B.btId = D.btId
                Order by A.createDate Desc");

                return connection.Query<VideoGallery>(query).ToList();
            }
        }
        public List<VideoGallery> GetVideoGallery(int? mf, int? model, int? category)
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string query = String.Format(@"select B.mfId, C.mfShortName, D.btId,D.btName,B.carName, A.vidURL, A.vidCourtsy,Replace(vidURL,'https://www.youtube.com/embed/','')VideoId
                from CarVideos A
                inner join Car B on A.carId = B.carId
                inner join Manufacturer C on B.mfId = C.mfId
                inner join BodyType D on B.btId = D.btId
                where 1=1");

                if (mf != null && mf != 0)
                {
                    query += " AND C.mfId = " + (mf ?? 0).ToString();
                }
                if (model != null && model != 0)
                {
                    query += " AND A.carId = " + (model ?? 0).ToString();
                }
                //if (category != null && category != 0)
                //{
                //    query += " AND A.carId = " + (category ?? 0).ToString();
                //}
                query += " ORDER BY createDate Desc";
                return connection.Query<VideoGallery>(query).ToList();
            }
        }
        public List<Car> GetCars(int? mfId)
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string query = String.Format(@"select carId, carName from Car where mfId = isnull(nullif({0},0), mfId) order by carName", mfId ?? 0);

                return connection.Query<Car>(query).ToList();
            }
        }

        public List<Car> GetCarByKeyWord(string keyWord)
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                if(keyWord.Trim() == "")
                {
                    return new List<Car>();
                }
                else
                {
                    string query = String.Format(@"with A as (
                    select carId, B.mfShortName + ' ' + A.carName carName from Car A
                    inner join Manufacturer B on A.mfId = B.mfId)
                    select * from A where A.carName like '%{0}%'", keyWord);

                    return connection.Query<Car>(query).ToList();
                }                
            }
        }
        public List<VideoType> GetVideoCategory()
        {
            using (IDbConnection connection = OpenConnection(dataConnection))
            {
                string query = String.Format(@"select vidTypeId, vidTypeName from VideoType");

                return connection.Query<VideoType>(query).ToList();
            }
        }
    }
}
