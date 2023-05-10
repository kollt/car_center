using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_car_center
{
    internal class Engine
    {
        private string model;
        private string fuel_type;//топ топлива
        private int power;//л.с
        private string manufacturer;
        private string volume;
        public string Model { get { return model; } set { model = value; } }
        public string Fuel_type { get { return fuel_type; } set { fuel_type = value; } }
        public int Power { get { return power; } set { power = value; } }
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string Volume { get { return volume; } set { volume = value; } }

        public Engine()
        {
            Model = "V6";
            Volume = "4,7";
            Manufacturer = "Mercedes";
            Power = 245;
            Fuel_type = "бензин";
        }

    }
}
