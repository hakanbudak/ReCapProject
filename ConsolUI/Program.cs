using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("------Default-------");
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + car.CarName + car.ColorName + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
            Console.Read();



            //Car car1 = new Car { BrandId = 4, ColorId = 4, ModelYear = 2013, DailyPrice = 150, Description = "Toyota" };

            //carManager.Add(car1);
            //Console.WriteLine("-------Added---------");
            //foreach (var add in carManager.GetAll())
            //{
            //    Console.WriteLine(add.Description);
            //}

            //Console.WriteLine("     ");


            //Console.WriteLine("------Delete-------");
            //carManager.Delete(car1);
            //foreach (var delete in carManager.GetAll())
            //{
            //    Console.WriteLine(delete.Description);
            //}
            //Console.WriteLine("------Update-------");
            //carManager.Update(new Car
            //{
            //    Id = 3,
            //    BrandId = 4,
            //    ColorId = 2,
            //    DailyPrice = 1000,
            //    Description = "Tesla Model S ",
            //    ModelYear = 2019
            //});

            //foreach (Car car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description +"\n" + car.DailyPrice + "\n" + car.ModelYear+"\n");

            //}
            //Console.ReadLine();
        }
    }
}
