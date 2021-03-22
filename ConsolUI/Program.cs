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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //RentalAdd(rentalManager);
            //CustomerAdd(customerManager);
            //UserAdd(userManager);

            //BrandAdd(brandManager);
            //BrandDelete(brandManager);
            //BrandUpdate(brandManager);
            //BrandGetAll(brandManager);

            //ColorAdd(colorManager);
            //ColorDelete(colorManager);
            //ColorUpdate(colorManager);
            //ColorGetAll(colorManager);


            //CarDetails(carManager);

            Console.Read();









            //Console.ReadLine();
        }

        private static void ColorGetAll(ColorManager colorManager)
        {
            var result8 = colorManager.GetAll();
            if (result8.Success == true)
            {
                Console.WriteLine(result8.Message);
            }
        }

        private static void ColorUpdate(ColorManager colorManager)
        {
            var result7 = colorManager.Update(new Color { ColorId = 4, ColorName = "Mat Siyah" });
            if (result7.Success == true)
            {
                Console.WriteLine(result7.Message);
            }
        }

        private static void ColorDelete(ColorManager colorManager)
        {
            var result5 = colorManager.Delete(new Color { ColorId = 2 });
            if (result5.Success == true)
            {
                Console.WriteLine(result5.Message);
            }
        }

        private static void ColorAdd(ColorManager colorManager)
        {
            var result6 = colorManager.Add(new Color { ColorId=2,ColorName = "Mor" });
            if (result6.Success == true)
            {
                Console.WriteLine(result6.Message);
            }
        }

        private static void BrandGetAll(BrandManager brandManager)
        {
            var result4 = brandManager.GetAll();
            if (result4.Success)
            {
                foreach (var brand in result4.Data)
                {
                    Console.WriteLine("BrandName: " + brand.BrandId + " / " + "BrandName: " + brand.BrandName);

                }
            }
        }

        private static void BrandUpdate(BrandManager brandManager)
        {
            var result3 = brandManager.Update(new Brand { BrandId = 2, BrandName = "Ferrari" });
            if (result3.Success == true)
            {
                Console.WriteLine(result3.Message);
            }
        }

        private static void BrandDelete(BrandManager brandManager)
        {
            var result2 = brandManager.Delete(new Brand { BrandId = 1 });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void BrandAdd(BrandManager brandManager)
        {
            var result13 = brandManager.GetAll();
            if (result13.Success == true)
            {
                foreach (var brand in result13.Data)
                {
                    Console.WriteLine("BrandName: " + brand.BrandId + " / " + "BrandName: " + brand.BrandName);

                }
            }
            else
            {
                Console.WriteLine(result13.Message);
            }
        }

        private static void UserAdd(UserManager userManager)
        {
            var result1 = userManager.GetAll();

            if (result1.Success == true)
            {
                foreach (var user in result1.Data)
                {
                    Console.WriteLine("FisrtName : " + " / " + user.FirstName + " / " + "LastName : " + user.LastName + " / " + "Email : " + " / " + user.Email);
                }

            }
            else
            {
                Console.WriteLine(result1.Message);
            }
        }

        private static void CarDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success == true)
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
        }

        private static void CustomerAdd(CustomerManager customerManager)
        {
            Console.Write("Kullanıcı ID : ");
            string _nullUserId = Console.ReadLine();

            if (_nullUserId == null)
            {
                Console.WriteLine("Lütfen Kullanıcı ID Değeri Giriniz!");

            }
            else
            {
                int _userIdForAdd = Convert.ToInt32(_nullUserId);
                Console.Write("Şirket Adı : ");
                string _companyNameForAdd = Console.ReadLine();

                Customer customer = new Customer
                {
                    UserId = _userIdForAdd,
                    CustomerName = _companyNameForAdd
                };
                var result = customerManager.Add(customer);
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAdd(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 02, 01, 10, 30, 0), ReturnDate = new DateTime(2021, 02, 07, 10, 30, 0) });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
