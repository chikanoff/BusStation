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
    public class TicketRepository : IRepository<Ticket>
    {
        private readonly MySqlConnection _conn;

        public TicketRepository(MySqlConnection conn)
        {
            _conn = conn;
        }
        public void Create(Ticket item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into tickets(tripId, startStopId, endStopId, price) values(@tripId, @startStopId, @endStopId, @price)", _conn);
                cmd.Parameters.AddWithValue("@tripId", item.TripId);
                cmd.Parameters.AddWithValue("@startStopId", item.StartStopId);
                cmd.Parameters.AddWithValue("@endStopId", item.EndStopId);
                cmd.Parameters.AddWithValue("@price", item.Price);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Ticket item)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand($"update tickets set tripId = @tripId, startStopId = @startStopId, endStopId = @endStopId, price = @price where id = @id", _conn);
                cmd.Parameters.AddWithValue("@tripId", item.TripId);
                cmd.Parameters.AddWithValue("@startStopId", item.StartStopId);
                cmd.Parameters.AddWithValue("@endStopId", item.EndStopId);
                cmd.Parameters.AddWithValue("@price", item.Price);
                cmd.Parameters.AddWithValue("@id", item.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from tickets where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Ticket> Get()
        {
            IList<Ticket> tickets = new List<Ticket>();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from tickets", _conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tickets.Add(new Ticket
                    {
                        Id = reader.GetInt32(0),
                        TripId = reader.GetInt32(1),
                        StartStopId = reader.GetInt32(2),
                        EndStopId = reader.GetInt32(3),
                        Price = reader.GetInt32(4)
                    });
                }
            }

            return tickets;
        }

        public Ticket Get(int id)
        {
            Ticket ticket = new Ticket();
            using (_conn)
            {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from tickets where id = @id", _conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ticket = new Ticket
                    {
                        Id = reader.GetInt32(0),
                        TripId = reader.GetInt32(1),
                        StartStopId = reader.GetInt32(2),
                        EndStopId = reader.GetInt32(3),
                        Price = reader.GetInt32(4)
                    };
                }
            }

            return ticket;
        }
    }
}
