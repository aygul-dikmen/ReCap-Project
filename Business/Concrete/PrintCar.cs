using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PrintCar 
    {
        public void listCars(List<Car> _cars)
        {
            
            for (int i = 0; i < _cars.Count; i++)
            {
                Car car = _cars[i];
                Console.WriteLine(car.Id + "      " + car.Description);
            }
            Console.WriteLine("--------------");
        }

    }
}
