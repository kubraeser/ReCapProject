using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors
                             on p.Id equals c.ColorId
                             join d in context.Brands
                             on p.Id equals d.BrandId
                             select new CarDetailDto
                             {
                                 ColorName = c.ColorName,
                                 CarName = p.Description,
                                 BrandName = d.BrandName,
                                 DailyPrice = p.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}
