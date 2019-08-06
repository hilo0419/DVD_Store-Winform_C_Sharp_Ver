using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Data
{
    public class EntityData<T> where T : class
    {
        public List<T> GetAll()
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                return context.Set<T>().ToList();
            }
        }

        public int GetCount()
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                return context.Set<T>().Count();
            }
        }

        public void Insert(T entity)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                context.Entry(entity).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (DVDRentEntities context = new DVDRentEntities())
            {
                context.Entry(entity).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }


    }
}
