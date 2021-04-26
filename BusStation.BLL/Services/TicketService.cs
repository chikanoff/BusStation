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
    public class TicketService : ITicketService
    {
        private IUnitOfWork _storage;

        public TicketService(IUnitOfWork storage)
        {
            _storage = storage;
        }
        public void Create(TicketDTO item)
        {
            try
            {
                Validate(item);
                Ticket ticket = new MapperConfiguration(cfg => cfg.CreateMap<TicketDTO, Ticket>())
                    .CreateMapper()
                    .Map<Ticket>(item);
                _storage.Tickets.Create(ticket);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить билет. {e.Message}");
            }
        }

        public void Update(TicketDTO item)
        {
            try
            {
                Validate(item);
                Ticket ticket = new MapperConfiguration(cfg => cfg.CreateMap<TicketDTO, Ticket>())
                    .CreateMapper()
                    .Map<Ticket>(item);
                _storage.Tickets.Update(ticket);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить билет. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.Tickets.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить билет. {e.Message}");
            }
        }

        public IEnumerable<TicketDTO> Get()
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

                return tickets;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить билеты. {exception.Message}");
            }
        }

        public TicketDTO Get(int id)
        {
            try
            {
                var t = Get().FirstOrDefault(x => x.Id == id);
                return t;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить билет. {exception.Message}");
            }
        }

        private void Validate(TicketDTO item)
        {
            try
            {
                _storage.Stops.Get(item.StartStopId);
            }
            catch
            {
                throw new Exception("Нет такой остановки");
            }
            try
            {
                _storage.Trips.Get(item.TripId);
            }
            catch
            {
                throw new Exception("Нет такого путешествия");
            }
            try
            {
                _storage.Stops.Get(item.EndStopId);
            }
            catch
            {
                throw new Exception("Нет такой остановки");
            }
        }

        public void Create(UserTicketDTO userTicketDTO)
        {
            throw new NotImplementedException();
        }
    }
}
