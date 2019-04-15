using Recruitment.Domain.Entities;
using Recruitment.Infra.Data.Repositories;
using Recruitment.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Service.Services
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        private BaseRepository<T> repository = new BaseRepository<T>();

        public T Post(T item) => repository.Insert(item);

        public T Put(T item) => repository.Update(item);
        
        public bool Delete(int id) => repository.Remove(id);

        public T Get(int id) => repository.Select(id);

        public IList<T> Get() => repository.SelectAll();
    }
}
