using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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
    public class UserService : IUserService
    {
        private IUnitOfWork _storage;

        public UserService(IUnitOfWork storage)
        {
            _storage = storage;
        }
        public void Create(UserDTO item)
        {
            try
            {
                Validate(item);
                User user = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>())
                    .CreateMapper()
                    .Map<User>(item);
                _storage.Users.Create(user);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно добавить пользователя. {e.Message}");
            }
        }

        public void Update(UserDTO item)
        {
            try
            {
                Validate(item);
                User user = new MapperConfiguration(cfg => cfg.CreateMap<UserDTO, User>())
                    .CreateMapper()
                    .Map<User>(item);
                _storage.Users.Update(user);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно обновить пользователя. {e.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                _storage.Users.Delete(id);
            }
            catch (Exception e)
            {
                throw new EntityServiceException($"Невозможно удалить пользователя {e.Message}");
            }
        }

        public IEnumerable<UserDTO> Get()
        {
            try
            {
                var users = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDTO>())
                    .CreateMapper()
                    .Map<List<UserDTO>>(_storage.Users.Get());

                return users;
            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить пользователей. {exception.Message}");
            }
        }

        public UserDTO Get(int id)
        {
            try
            {
                var user = Get().FirstOrDefault(x => x.Id == id);
                return user;

            }
            catch (Exception exception)
            {
                throw new EntityServiceException($"Невозможно получить пользователя. {exception.Message}");
            }
        }

        private void Validate(UserDTO item)
        {
            if (string.IsNullOrEmpty(item.Username))
            {
                throw new ValidateException("Bad username", "username");
            }
            if (string.IsNullOrEmpty(item.Password))
            {
                throw new ValidateException("Bad password", "password");
            }

        }
    }
}
