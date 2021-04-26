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
    public class StopService : IStopService
    {
        private IUnitOfWork _storage;

        public StopService(IUnitOfWork storage)
        {
            _storage = storage;
        }
        public void Create(StopDTO item)
        {
            try
            {
                Validate(item);
                Stop stop = new MapperConfiguration(cfg => cfg.CreateMap<StopDTO, Stop>())
                    .CreateMapper()
                    .Map<Stop>(item);
                _storage.Stops.Create(stop);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить остановку. {e.Message}");
            }
        }

        public void Update(StopDTO item)
        {
            try
            {
                Validate(item);
                Stop stop = new MapperConfiguration(cfg => cfg.CreateMap<StopDTO, Stop>())
                    .CreateMapper()
                    .Map<Stop>(item);
                _storage.Stops.Update(stop);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить остановку. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.Stops.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить остановку {e.Message}");
            }
        }

        public IEnumerable<StopDTO> Get()
        {
            try
            {
                var stops = new MapperConfiguration(cfg => cfg.CreateMap<Stop, StopDTO>())
                    .CreateMapper()
                    .Map<List<StopDTO>>(_storage.Stops.Get());

                return stops;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить остановки. {exception.Message}");
            }
        }

        public StopDTO Get(int id)
        {
            try
            {
                var stop = Get().FirstOrDefault(x => x.Id == id);
                return stop;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить остановку. {exception.Message}");
            }
        }

        private void Validate(StopDTO item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                throw new ValidateException("bad name", "stop name");
            }
        }
    }
}
