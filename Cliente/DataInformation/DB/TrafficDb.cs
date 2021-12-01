using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataInformation.DB
{
    public class TrafficDb
    {
        string root;

        public TrafficDb(string dbInstance)
        {
            try
            {
                string folder = Path.Combine("C:\\TrafficDb", dbInstance);
                root = Path.Combine(folder, "TrafficDb.db");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                using (SQLiteConnection db = new SQLiteConnection(root))
                {
                    db.CreateTable<TrafficLight>();
                    db.CreateTable<ColorLight>();
                    db.CreateTable<User>();

                    User user = new User();
                    user.Name = "Pablo Lopez";
                    user.Email = "plopez@gmail.com";
                    user.Password = "holamundo";
                    db.InsertOrReplace(user);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SetTraffic(TrafficLight trafficLight)
        {
            using (SQLiteConnection db = new SQLiteConnection(root))
            {
                db.InsertOrReplace(trafficLight);
            }
        }

        public List<TrafficLight> GetTraffics()
        {
            using (SQLiteConnection db = new SQLiteConnection(root))
            {
               List<TrafficLight> traffics = db.Query<TrafficLight>("select * from TrafficLight");
                return traffics;
            }
        }

        public void SetColor(ColorLight colorLight)
        {
            using (SQLiteConnection db = new SQLiteConnection(root))
            {
                db.InsertOrReplace(colorLight);
            }
        }

        public List<ColorLight> GetColors()
        {
            using (SQLiteConnection db = new SQLiteConnection(root))
            {
                List<ColorLight> lights = db.Query<ColorLight>("select * from ColorLight");
                return lights;
            }
        }

        public bool ValidaUser(User user)
        {
            using (SQLiteConnection db = new SQLiteConnection(root))
            {
                var userLoged = db.Get<User>(x => x.Email == user.Email);
                if(userLoged == null)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
