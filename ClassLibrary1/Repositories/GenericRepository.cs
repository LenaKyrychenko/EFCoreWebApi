
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using ClassLibrary2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        private ApplicationContext context = null;
        private DbSet<T> table = null;

        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
            table = context.Set<T>();
        }
        public void Delete(int id)
        {
            var entity = table.SingleOrDefault(s => s.Id == id);
            table.Remove(entity);
            context.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            return table.AsEnumerable();
        }

        public T GetById(int id)
        {
            return table.SingleOrDefault(s => s.Id == id);
        }

        public void Add(T obj)
        {
            table.Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            var entity = table.SingleOrDefault(s => s.Id == obj.Id);
            table.Update(entity);
            context.SaveChanges();
        }
    }
}
