using Recruitment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Infra.Data.Interfaces
{
    public interface IActions<T> where T : BaseEntity
    {
        T Insert(T obj);

        T Update(T obj);

        bool Remove(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
