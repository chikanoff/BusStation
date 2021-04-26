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
    public class TripService : ITripService
    {
        private IUnitOfWork _storage;

        public TripService(IUnitOfWork storage)
        {
            _storage = storage;
        }
        public void Create(TripDTO item)
        {
            try
            {
                Validate(item);
                Trip trip = new MapperConfiguration(cfg => cfg.CreateMap<TripDTO, Trip>())
                    .CreateMapper()
                    .Map<Trip>(item);
                _storage.Trips.Create(trip);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить путешствие. {e.Message}");
            }
        }

        public void Update(TripDTO item)
        {
            try
            {
                Validate(item);
                Trip trip = new MapperConfiguration(cfg => cfg.CreateMap<TripDTO, Trip>())
                    .CreateMapper()
                    .Map<Trip>(item);
                _storage.Trips.Update(trip);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить путешествие. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.Trips.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить путешствеи {e.Message}");
            }
        }

        public IEnumerable<TripDTO> Get()
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

                return trips;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить путшествия. {exception.Message}");
            }
        }

        public TripDTO Get(int id)
        {
            try
            {
                var rs = Get().FirstOrDefault(x => x.Id == id);
                return rs;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить путешествие. {exception.Message}");
            }
        }

        private void Validate(TripDTO item)
        {
            try
            {
                _storage.Routes.Get(item.RouteId);
            }
            catch
            {
                throw new Exception("Нет такого маршрута");
            }
            try
            {
                _storage.Buses.Get(item.BusId);
            }
            catch
            {
                throw new Exception("Нет такого автобуса");
            }
        }
    }
}
