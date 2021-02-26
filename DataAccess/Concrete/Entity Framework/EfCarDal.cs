using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                if (entity.Description.Length >= 2 && entity.DailyPrice >= 0)
                {
                    ;
                }

                {
                    var addedEntity = context.Add(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                    var deletedEntity = context.Add(entity);
                    deletedEntity.State = EntityState.Added;
                    context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();

            }
        }

        public void Update(Car entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                    var updatedEntity = context.Add(entity);
                    updatedEntity.State = EntityState.Added;
                    context.SaveChanges();
            }
        }
    }
}
