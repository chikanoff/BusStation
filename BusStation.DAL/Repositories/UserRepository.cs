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
    public class UserRepository : IRepository<User>
    {
        private readonly MySqlConnection _conn;

        public UserRepository(MySqlConnection conn)
        {
            _conn = conn;
        }
        public void Create(User item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into users(username, password, isAdmin) values(@username, @password, @isAdmin)", _conn);
                cmd.Parameters.AddWithValue("@username", item.Username);
                cmd.Parameters.AddWithValue("@password", item.Password);
                cmd.Parameters.AddWithValue("@isAdmin", item.IsAdmin);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(User item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand($"update users set username = @username, password = @password, isAdmin = @isAdmin where id = @id", _conn);
                cmd.Parameters.AddWithValue("@username", item.Username);
                cmd.Parameters.AddWithValue("@password", item.Password);
                cmd.Parameters.AddWithValue("@isAdmin", item.IsAdmin);
                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from users where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> Get()
        {
            IList<User> users = new List<User>();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from users", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        IsAdmin = reader.GetBoolean(3)
                    });
                }
            }

            return users;
        }

        public User Get(int id)
        {
            User user = new User();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from users where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new User
                    {
                        Id = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2),
                        IsAdmin = reader.GetBoolean(3)
                    };
                }
            }

            return user;
        }
    }
}
