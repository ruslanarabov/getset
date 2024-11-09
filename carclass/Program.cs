using carclass;

Car car1 = new Car(1, "BMW", 300);
Car car2 = new Car(2, "Mercedes", 280);
Car car3 = new Car(3, "Lada", 180);

Gallery gallery1 = new Gallery();
gallery1.AddCar(car1);
gallery1.AddCar(car2);
gallery1.AddCar(car3);

// foreach (var item in gallery1.cars)
// {
//     System.Console.WriteLine(item.Name);
// }

// Car findCar = gallery1.FindCarById(2);
// {
//     if (findCar != null)
//     {
//         System.Console.WriteLine(findCar.Name);
//     }
//     else
//     {
//         System.Console.WriteLine("Bele Id'li masin yoxdur.");
//     }
// }

// System.Console.WriteLine("Butun Masinlar");
// gallery1.ShowAllCars();


// Car findCarByCode = gallery1.FindCarByCarCode("ME1001");
// {
//     if (findCarByCode != null)
//     {
//         System.Console.WriteLine(findCarByCode.Name);
//     }
//     else
//     {
//         System.Console.WriteLine("Bu kodda masin yoxdur.");
//     }
// }

//  Car[] findCarsBySpeedInterval = gallery1.FindCarsBySpeedInterval(160,290);
//     {
//         foreach (var car in findCarsBySpeedInterval)
//         {
//             System.Console.WriteLine(car.Name);
//         }
//     }
