using Recruitment.Domain.Entities;
using System.Collections.Generic;

namespace Recruitment.Service.Interfaces
{
    public interface IService<T> where T : BaseEntity
    {
        T Post(T item);

        T Put(T item);

        bool Delete(int id);

        T Get(int id);

        IList<T> Get();
    }
}
