using FMSApp.BLL.Services.Interface;
using FMSApp.DAL.Dtos;
using FMSApp.DAL.Models;
using FMSApp.DAL.Repository;
using FMSApp.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSApp.BLL.Services
{
    internal class GenericService<TDto, TEntity> : IGenericService<TDto, TEntity> where TDto : BaseDto where TEntity : BaseEntity, new()
    {

        private readonly IGenericRepository<TEntity> _repository;

        public GenericService(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public Task<TDto> Add(TEntity entity)
        {
            return _repository.Add(entity);
        }

        public Task<T> Get(int id)
        {
            return _repository.Get(id);
        }

        public Task<IQueryable<T>> GetAll()
        {
            return _repository.GetAll();
        }

        public T Remove(int id)
        {
            return _repository.Remove(id);
        }

        public T Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
