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
    public class RouteService : IRouteService
    {
        private IUnitOfWork _storage;

        public RouteService(IUnitOfWork storage)
        {
            _storage = storage;
        }
        public void Create(RouteDTO item)
        {
            try
            {
                Validate(item);
                Route route = new MapperConfiguration(cfg => cfg.CreateMap<RouteDTO, Route>())
                    .CreateMapper()
                    .Map<Route>(item);
                _storage.Routes.Create(route);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить маршрут. {e.Message}");
            }
        }

        public void Update(RouteDTO item)
        {
            try
            {
                Validate(item);
                Route route = new MapperConfiguration(cfg => cfg.CreateMap<RouteDTO, Route>())
                    .CreateMapper()
                    .Map<Route>(item);
                _storage.Routes.Update(route);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить маршрут. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.Routes.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить маршрут {e.Message}");
            }
        }

        public IEnumerable<RouteDTO> Get()
        {
            try
            {
                var routes = new MapperConfiguration(cfg => cfg.CreateMap<Route, RouteDTO>())
                    .CreateMapper()
                    .Map<List<RouteDTO>>(_storage.Routes.Get());
                
                return routes;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить маршруты. {exception.Message}");
            }
        }

        public RouteDTO Get(int id)
        {
            try
            {
                var route = Get().FirstOrDefault(x => x.Id == id);
                return route;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить маршрут. {exception.Message}");
            }
        }

        private void Validate(RouteDTO item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                throw new ValidateException("bad name", "route name");
            }
        }
    }
}
