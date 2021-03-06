﻿using Recruitment.Domain.Entities;
using Recruitment.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using Recruitment.Infra.Data.Contexts;
using System.Linq;

namespace Recruitment.Infra.Data.Repositories
{
    public class BaseRepository<T> : IActions<T> where T : BaseEntity
    {
        private readonly BookstoreContext context = new BookstoreContext();

        public T Insert(T item)
        {
            context.Set<T>().Add(item);
            context.SaveChanges();
            return item;
        }

        public T Update(T item)
        {
            try
            {
                context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                if (context.SaveChanges() > 0)
                    return item;
                else
                    throw new Exception("Update not performed");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool Remove(int id)
        {
            context.Set<T>().Remove(Select(id));
            if (context.SaveChanges() > 0)
                return true;
            return false;
        }

        public T Select(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IList<T> SelectAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
