using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            PrintCar pc = new PrintCar();
            pc.listCars(carManager.GetAll());
            
            Car car1 = new Car() { Id = 9, BrandId = 3, ColorID = 5, DailyPrice = 788, ModelYear = 1999, Description = "This is an old car." };
            carManager.Add(car1) ;
            pc.listCars(carManager.GetAll());
            
            Car newCar1=new Car() { Id = 9, BrandId = 2, ColorID = 5, DailyPrice = 788, ModelYear = 1999, Description = "This is the new description for old car." };
            carManager.Update(newCar1);
            pc.listCars(carManager.GetAll());

            carManager.Delete(newCar1);
            pc.listCars(carManager.GetAll());

            Console.WriteLine(carManager.GetByID(3).Description);
        }
    }
}
