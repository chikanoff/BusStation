using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusStation.BLL.DTO;
using BusStation.BLL.Exceptions;
using BusStation.BLL.Interfaces.EntityServices;
using BusStation.DAL.Entities;
using BusStation.DAL.Interfaces;

namespace BusStation.BLL.Services
{
    public class UserTicketService : IUserTicketService
    {
        private IUnitOfWork _storage;

        public UserTicketService(IUnitOfWork storage)
        {
            _storage = storage;
        }
        public void Create(UserTicketDTO item)
        {
            try
            {
                Validate(item);
                UserTicket userT = new MapperConfiguration(cfg => cfg.CreateMap<UserTicketDTO, UserTicket>())
                    .CreateMapper()
                    .Map<UserTicket>(item);
                _storage.UserTickets.Create(userT);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить билет пользователю. {e.Message}");
            }
        }

        public void Update(UserTicketDTO item)
        {
            try
            {
                Validate(item);
                UserTicket userT = new MapperConfiguration(cfg => cfg.CreateMap<UserTicketDTO, UserTicket>())
                    .CreateMapper()
                    .Map<UserTicket>(item);
                _storage.UserTickets.Update(userT);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить билет пользователя. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.UserTickets.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить билет пользователя {e.Message}");
            }
        }

        public IEnumerable<UserTicketDTO> Get()
        {
            try
            {
                var routes = new MapperConfiguration(cfg => cfg.CreateMap<Route, RouteDTO>())
                    .CreateMapper()
                    .Map<List<RouteDTO>>(_storage.Routes.Get());
                var categories = new MapperConfiguration(cfg => cfg.CreateMap<BusCategory, BusCategoryDTO>())
                    .CreateMapper()
                    .Map<List<BusCategoryDTO>>(_storage.BusCategories.Get());
                var buses = new MapperConfiguration(cfg => cfg.CreateMap<Bus, BusDTO>())
                    .CreateMapper()
                    .Map<List<BusDTO>>(_storage.Buses.Get());
                buses.ForEach(x => x.Category = categories.FirstOrDefault(k => k.Id == x.CategoryId));
                var trips = new MapperConfiguration(cfg => cfg.CreateMap<Trip, TripDTO>())
                    .CreateMapper()
                    .Map<List<TripDTO>>(_storage.Trips.Get());
                trips.ForEach(x => x.Bus = buses.FirstOrDefault(k => k.Id == x.BusId));
                trips.ForEach(x => x.Route = routes.FirstOrDefault(k => k.Id == x.RouteId));

                var stops = new MapperConfiguration(cfg => cfg.CreateMap<Stop, StopDTO>())
                    .CreateMapper()
                    .Map<List<StopDTO>>(_storage.Stops.Get());

                var tickets = new MapperConfiguration(cfg => cfg.CreateMap<Ticket, TicketDTO>())
                    .CreateMapper()
                    .Map<List<TicketDTO>>(_storage.Tickets.Get());

                tickets.ForEach(x => x.StartStop = stops.FirstOrDefault(k => k.Id == x.StartStopId));
                tickets.ForEach(x => x.EndStop = stops.FirstOrDefault(k => k.Id == x.EndStopId));
                tickets.ForEach(x => x.Trip = trips.FirstOrDefault(k => k.Id == x.TripId));
                var users = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>())
                    .CreateMapper()
                    .Map<List<UserDTO>>(_storage.Users.Get());
                var userT = new MapperConfiguration(cfg => cfg.CreateMap<UserTicket, UserTicketDTO>())
                    .CreateMapper()
                    .Map<List<UserTicketDTO>>(_storage.UserTickets.Get());

                userT.ForEach(x => x.User = users.FirstOrDefault(k => k.Id == x.UserId));
                userT.ForEach(x => x.Ticket = tickets.FirstOrDefault(k => k.Id == x.TicketId));

                return userT;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить билеты пользователя. {exception.Message}");
            }
        }

        public UserTicketDTO Get(int id)
        {
            try
            {
                var userT = Get().FirstOrDefault(x => x.Id == id);
                return userT;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить билеты пользователя. {exception.Message}");
            }
        }

        private void Validate(UserTicketDTO item)
        {
            try
            {
                _storage.Tickets.Get(item.TicketId);
            }
            catch
            {
                throw new Exception("Нет такого билета");
            }
            try
            {
                _storage.Users.Get(item.UserId);
            }
            catch
            {
                throw new Exception("Нет такого пользователя");
            }
        }
    }
}
