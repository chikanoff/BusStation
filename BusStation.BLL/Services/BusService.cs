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
    public class BusService : IBusService
    {
        private IUnitOfWork _storage;

        public BusService(IUnitOfWork storage)
        {
            _storage = storage;
        }
        public void Create(BusDTO item)
        {
            try
            {
                Validate(item);
                Bus bus = new MapperConfiguration(cfg => cfg.CreateMap<BusDTO, Bus>())
                    .CreateMapper()
                    .Map<Bus>(item);
                _storage.Buses.Create(bus);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить автобус. {e.Message}");
            }
        }

        public void Update(BusDTO item)
        {
            try
            {
                Validate(item);
                Bus disc = new MapperConfiguration(cfg => cfg.CreateMap<BusDTO, Bus>())
                    .CreateMapper().Map<Bus>(item);
                _storage.Buses.Update(disc);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить автобус. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.Buses.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить автобус {e.Message}");
            }
        }

        public IEnumerable<BusDTO> Get()
        {
            try
            {
                var categories = new MapperConfiguration(cfg => cfg.CreateMap<BusCategory, BusCategoryDTO>())
                    .CreateMapper()
                    .Map<List<BusCategoryDTO>>(_storage.BusCategories.Get());
                var buses = new MapperConfiguration(cfg => cfg.CreateMap<Bus, BusDTO>())
                    .CreateMapper()
                    .Map<List<BusDTO>>(_storage.Buses.Get());
                buses.ForEach(x => x.Category = categories.FirstOrDefault(k => k.Id == x.CategoryId));
                return buses;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить автобусы. {exception.Message}");
            }
        }

        public BusDTO Get(int id)
        {
            try
            {
                var bus = Get().FirstOrDefault(x => x.Id == id);
                return bus;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить автобус. {exception.Message}");
            }
        }

        private void Validate(BusDTO item)
        {
            if (item.Capacity <= 0)
            {
                throw new ValidateException("bad number", "capacity");
            }
            try
            {
                _storage.BusCategories.Get(item.CategoryId);
            }
            catch
            {
                throw new Exception("Нет такой категории");
            }
        }
    }
}
