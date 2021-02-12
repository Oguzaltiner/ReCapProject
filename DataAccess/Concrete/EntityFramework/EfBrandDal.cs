using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var addedEntity = reCapContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                reCapContext.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var deletedEntity = reCapContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                reCapContext.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                return reCapContext.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                return filter == null
                    ? reCapContext.Set<Brand>().ToList()
                    : reCapContext.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var updatedEntity = reCapContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                reCapContext.SaveChanges();
            }
        }
    }
}
