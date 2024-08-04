using FMSApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSApp.DAL.Repository.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public Task<T> Add(T entity);
        public T Update(T entity);
        public Task<T> Get(int id);
        public Task<IQueryable<T>> GetAll ();
        public T Remove(int id);
    }
}
