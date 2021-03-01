using Business.Concrete;
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
            CarTest();

            //ColorTest();

            //BrandTest();

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //CarManager carManager = new CarManager(new EfCarDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());



            //Brand brand1 = new Brand { BrandName = "Opel" };
            //Brand brand2 = new Brand { BrandName = "Toyoto" };
            //Brand brand3 = new Brand { BrandName = "Suzuki" };
            //Brand brand4 = new Brand { BrandName = "BMW" };
            //Brand brand5 = new Brand { BrandName = "Ford" };

            //brandManager.Add(brand1);
            //brandManager.Add(brand2);
            //brandManager.Add(brand3);
            //brandManager.Add(brand4);
            //brandManager.Add(brand5);

            //Color color1 = new Color { ColorName = "kırmızı" };
            //Color color2 = new Color { ColorName = "siyah" };
            //Color color3 = new Color { ColorName = "beyaz" };
            //Color color4 = new Color { ColorName = "gri" };
            //Color color5 = new Color { ColorName = "mavi" };

            //colorManager.Add(color1);
            //colorManager.Add(color2);
            //colorManager.Add(color3);
            //colorManager.Add(color4);
            //colorManager.Add(color5);


        
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
