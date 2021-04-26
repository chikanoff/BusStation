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
    public class UserTicketRepository : IRepository<UserTicket>
    {
        private readonly MySqlConnection _conn;

        public UserTicketRepository(MySqlConnection conn)
        {
            _conn = conn;
        }
        public void Create(UserTicket item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into usertickets(userId, ticketId) values(@userId, @ticketId)", _conn);
                cmd.Parameters.AddWithValue("@userId", item.UserId);
                cmd.Parameters.AddWithValue("@ticketId", item.TicketId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(UserTicket item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand($"update usertickets set userId = @userId, ticketId = @ticketId where id = @id", _conn);
                cmd.Parameters.AddWithValue("@userId", item.UserId);
                cmd.Parameters.AddWithValue("@ticketId", item.TicketId);
                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from usertickets where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<UserTicket> Get()
        {
            IList<UserTicket> userTickets = new List<UserTicket>();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from usertickets", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userTickets.Add(new UserTicket
                    {
                        Id = reader.GetInt32(0),
                        UserId = reader.GetInt32(1),
                        TicketId = reader.GetInt32(2)
                    });
                }
            }

            return userTickets;
        }

        public UserTicket Get(int id)
        {
            UserTicket userTicket = new UserTicket();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from usertickets where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userTicket = new UserTicket
                    {
                        Id = reader.GetInt32(0),
                        UserId = reader.GetInt32(1),
                        TicketId = reader.GetInt32(2)
                    };
                }
            }

            return userTicket;
        }
    }
}
