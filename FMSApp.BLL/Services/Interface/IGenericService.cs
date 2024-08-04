using FMSApp.DAL.Dtos;
using FMSApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSApp.BLL.Services.Interface
{
    internal interface IGenericService<TDto,TEntity> where TDto : BaseDto where TEntity : BaseEntity
    {
        public Task<TDto> Add(TEntity entity);
        public TDto Update(TEntity entity);
        public Task<TDto> Get(int id);
        public Task<IQueryable<TDto>> GetAll();
        public TDto Remove(int id);
    }
}
