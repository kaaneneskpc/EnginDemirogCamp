using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var addedContext = context.Entry(entity);
                addedContext.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedContext = context.Entry(entity);
                deletedContext.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Category>().ToList() : context.Set<Category>().Where(filter).ToList();
            }
        }

        public void Update(Category entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
