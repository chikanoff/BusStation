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
    public class RouteStopService : IRouteStopService
    {
        private IUnitOfWork _storage;

        public RouteStopService(IUnitOfWork storage)
        {
            _storage = storage;
        }

        public void Create(RouteStopDTO item)
        {
            try
            {
                Validate(item);
                RouteStop routeStop = new MapperConfiguration(cfg => cfg.CreateMap<RouteStopDTO, RouteStop>())
                    .CreateMapper()
                    .Map<RouteStop>(item);
                _storage.RouteStops.Create(routeStop);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить остановку в маршрту. {e.Message}");
            }
        }

        public void Update(RouteStopDTO item)
        {
            try
            {
                Validate(item);
                RouteStop routeStop = new MapperConfiguration(cfg => cfg.CreateMap<RouteStopDTO, RouteStop>())
                    .CreateMapper()
                    .Map<RouteStop>(item);
                _storage.RouteStops.Update(routeStop);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить остановку в маршрутах. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.RouteStops.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить остановку в маршруте {e.Message}");
            }
        }

        public IEnumerable<RouteStopDTO> Get()
        {
            try
            {
                var routes = new MapperConfiguration(cfg => cfg.CreateMap<Route, RouteDTO>())
                    .CreateMapper()
                    .Map<List<RouteDTO>>(_storage.Routes.Get());
                var stops = new MapperConfiguration(cfg => cfg.CreateMap<Stop, StopDTO>())
                    .CreateMapper()
                    .Map<List<StopDTO>>(_storage.Stops.Get());
                var routeStops = new MapperConfiguration(cfg => cfg.CreateMap<RouteStop, RouteStopDTO>())
                    .CreateMapper()
                    .Map<List<RouteStopDTO>>(_storage.RouteStops.Get());
                routeStops.ForEach(x => x.Stop = stops.FirstOrDefault(k => k.Id == x.StopId));
                routeStops.ForEach(x => x.Route = routes.FirstOrDefault(k => k.Id == x.RouteId));

                return routeStops;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить остановки маршрутов. {exception.Message}");
            }
        }

        public RouteStopDTO Get(int id)
        {
            try
            {
                var rs = Get().FirstOrDefault(x => x.Id == id);
                return rs;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить остановку маршрута. {exception.Message}");
            }
        }

        private void Validate(RouteStopDTO item)
        {
            if (item.DistanceFromStart <= 0 || item.StopNumberInRoute <= 0)
            {
                throw new ValidateException("bad number", "int value more than 0");
            }
        }
    }
}
