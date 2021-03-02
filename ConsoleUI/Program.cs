using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //ColorTest();

            //BrandTest();

            RentalTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental { CarId = 3, CustomerId = 3, RentDate = DateTime.Now, ReturnDate = DateTime.Today , CarName = "Toyota", CustomerName = "Beyza" };
            var result = rentalManager.Add(rental);
            var result2 = rentalManager.GetCarDetails();
            if (result.Success == true && result2.Success == true)
            {
                Console.WriteLine(Messages.RentalAdded);
            }
            else
            {
                Console.WriteLine(Messages.AddError);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetById(2))
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetById(2))
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "/" + car.BrandId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }



}
