using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carclass
{
    public class Car
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public double Speed {get; set;}
        public string CarCode {get; set;}
        private int _carCounter = 1000;


        public Car(int id, string name, double speed)
        {
            Id = id;
            Name = name;
            Speed = speed;
            CarCode = GenerateCarCode();
        }
        private string GenerateCarCode()
        {
            return Name.Substring(0, 2).ToUpper() + _carCounter++;
        }
    }
}
