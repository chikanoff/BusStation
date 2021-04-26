using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class BusCategoryService : IBusCategoryService
    {
        private IUnitOfWork _storage;

        public BusCategoryService(IUnitOfWork storage)
        {
            _storage = storage;
        }
        public void Create(BusCategoryDTO item)
        {
            try
            {
                Validate(item);
                BusCategory busCategory = new MapperConfiguration(cfg => cfg.CreateMap<BusCategoryDTO, BusCategory>())
                    .CreateMapper()
                    .Map<BusCategory>(item);
                _storage.BusCategories.Create(busCategory);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить категорию. {e.Message}");
            }
        }

        public void Update(BusCategoryDTO item)
        {
            try
            {
                Validate(item);
                BusCategory disc = new MapperConfiguration(cfg => cfg.CreateMap<BusCategoryDTO, BusCategory>())
                    .CreateMapper().Map<BusCategory>(item);
                _storage.BusCategories.Update(disc);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить категорию. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.BusCategories.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить категорию {e.Message}");
            }
        }

        public IEnumerable<BusCategoryDTO> Get()
        {
            try
            {
                var categories = new MapperConfiguration(cfg => cfg.CreateMap<BusCategory, BusCategoryDTO>())
                    .CreateMapper()
                    .Map<List<BusCategoryDTO>>(_storage.BusCategories.Get());
                return categories;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить категории. {exception.Message}");
            }
        }

        public BusCategoryDTO Get(int id)
        {
            try
            {
                var cat = Get().FirstOrDefault(x => x.Id == id);
                return cat;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить категорию. {exception.Message}");
            }
        }

        private void Validate(BusCategoryDTO item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                throw new ValidateException("Неверное название категории", "category name");
            }

            if (item.PriceForOneKm <= 0)
            {
                throw new ValidateException("неверная цена за километр", "price for one km");
            }
        }
    }
}
