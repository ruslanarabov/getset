using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carclass
{
    public class Gallery
    {
        public int Id;
        public string Name;


        

        public Car[] cars = new Car[0];
        public void AddCar (Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[^1] = car;
        }
        public void ShowAllCars()
        {
            foreach (var car in cars)
            {
                System.Console.WriteLine($"Id: {car.Id}, Name {car.Name}, Speed {car.Speed}, CarCode {car.CarCode} ");
            }
        }
        public Car[] GetAllCars()
        {
            return cars;
        }

        public Car FindCarById (int id)
        {
            foreach (var car in cars)
            {
                if (car.Id == id)
                {
                    return car;
                }
            }

            return null;
        }
        public Car FindCarByCarCode(string code)
        {
            foreach (var car in cars)
            {
                if (car.CarCode == code)
                {
                    return car;
                }
            }
            return null;
        }
        public Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        {
            Car[] findCarsBySpeedInterval = new Car[0];
            foreach (var car in cars)
            {
                if (car.Speed > minSpeed && car.Speed <= maxSpeed)
                {
                    Array.Resize(ref findCarsBySpeedInterval, findCarsBySpeedInterval.Length + 1);
                    findCarsBySpeedInterval[^1] = car;
                }
            }
            return findCarsBySpeedInterval;
        }
        

    }
}