using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStation.DAL.Connections;
using BusStation.DAL.Entities;
using BusStation.DAL.Interfaces;
using MySql.Data.MySqlClient;

namespace BusStation.DAL.Repositories
{
    public class BusCategoryRepository : IRepository<BusCategory>
    {
        private readonly MySqlConnection _conn;

        public BusCategoryRepository(MySqlConnection conn)
        {
            _conn = conn;
        }

        public void Create(BusCategory item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into buscategories(name, priceForOneKm) values(@name, @priceForOneKm)", _conn);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@priceForOneKm", item.PriceForOneKm);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(BusCategory item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand($"update buscategories set name = @name, priceForOneKm = @priceForOneKm where id = @id", _conn);
                cmd.Parameters.AddWithValue("@name", item.Name);
                cmd.Parameters.AddWithValue("@priceForOneKm", item.PriceForOneKm);
                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from buscategories where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<BusCategory> Get()
        {
            IList<BusCategory> categories = new List<BusCategory>();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from buscategories", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new BusCategory
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        PriceForOneKm = reader.GetInt32(2)
                    });
                }
            }

            return categories;
        }

        public BusCategory Get(int id)
        {
            BusCategory category = new BusCategory();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from buscategories where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    category = new BusCategory
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        PriceForOneKm = reader.GetInt32(2)
                    };
                }
            }

            return category;
        }
    }
}
