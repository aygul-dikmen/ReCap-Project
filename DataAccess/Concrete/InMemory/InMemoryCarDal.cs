using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{ Id=1,BrandId=1,ColorID=1,DailyPrice=100,ModelYear=2015,Description="Nice Car"},
                new Car{ Id=2,BrandId=1,ColorID=1,DailyPrice=150,ModelYear=2016,Description="Good"},
                new Car{ Id=3,BrandId=2,ColorID=1,DailyPrice=200,ModelYear=2017,Description="Amazing"},
                new Car{ Id=4,BrandId=2,ColorID=2,DailyPrice=300,ModelYear=2018,Description="The best"},
                new Car{ Id=5,BrandId=3,ColorID=3,DailyPrice=400,ModelYear=2019,Description="Great"},
                new Car{ Id=6,BrandId=4,ColorID=4,DailyPrice=500,ModelYear=2020,Description="Perfect"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToBeDeleted = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToBeDeleted);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetByID(int carId)
        {
            Car carToBeReturned = _cars.SingleOrDefault(c => c.Id == carId);
            return carToBeReturned;
        }

        public void Update(Car car)
        {
            Car carToBeUpdated = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToBeUpdated.Id = car.Id;
            carToBeUpdated.ColorID = car.ColorID;
            carToBeUpdated.BrandId = car.BrandId;
            carToBeUpdated.DailyPrice = car.DailyPrice;
            carToBeUpdated.ModelYear = car.ModelYear;
            carToBeUpdated.Description = car.Description;
        }
    }
}
