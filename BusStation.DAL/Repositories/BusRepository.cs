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
    public class BusRepository : IRepository<Bus>
    {
        private readonly MySqlConnection _conn;

        public BusRepository(MySqlConnection conn)
        {
            _conn = conn;
        }

        public void Create(Bus item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into buses(capacity, categoryId) values(@capacity, @categoryId)", _conn);
                cmd.Parameters.AddWithValue("@capacity", item.Capacity);
                cmd.Parameters.AddWithValue("@categoryId", item.CategoryId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Bus item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand($"update buses set capacity = @capacity, categoryId = @categoryId where id = @id", _conn);
                cmd.Parameters.AddWithValue("@capacity", item.Capacity);
                cmd.Parameters.AddWithValue("@categoryId", item.CategoryId);
                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from buses where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Bus> Get()
        {
            IList<Bus> buses = new List<Bus>();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from buses", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    buses.Add(new Bus
                    {
                        Id = reader.GetInt32(0),
                        Capacity = reader.GetInt32(1),
                        CategoryId = reader.GetInt32(2)
                    });
                }
            }

            return buses;
        }

        public Bus Get(int id)
        {
            Bus bus = new Bus();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from buses where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bus = new Bus
                    {
                        Id = reader.GetInt32(0),
                        Capacity = reader.GetInt32(1),
                        CategoryId = reader.GetInt32(2)
                    };
                }
            }

            return bus;
        }
    }
}
