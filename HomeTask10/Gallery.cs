using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask10
{
    public class Gallery
    {

        Car[] cars = new Car[0];
        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[^1] = car;
        }
        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Name);
            }
        }
        public Car[] GetAllCars()
        {
            Car[] cars1 = new Car[0];
            foreach (Car car in cars)
            {
                Array.Resize(ref cars1, cars1.Length + 1);
                cars1[^1] = car;

            }
            return cars1;
        }
        public Car FindCarById(int id)
        {
            foreach (Car car in cars)
            {
                if (car.ID == id)
                    return car;
            }
            return null;
        }

        public Car FindCarByCarCode(string CarCode)
        {

            foreach (Car car in cars)
            {
                string Code = CarCode.ToUpper();
                if (car.Carcode == Code)
                    return car;
            }
            return null;
        }
        public Car[] FindCarBySpeedInterval(int min, int max)
        {
            Car[] cars2 = new Car[0];
            foreach (Car car in cars)
            {
                if (car.Speed >= min && car.Speed <= max)
                {
                    Array.Resize(ref cars2, cars2.Length + 1);
                    cars2[^1] = car;
                }
            }
            return cars2;
        }


    }
}
