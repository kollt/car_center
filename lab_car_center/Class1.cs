using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab_car_center
{

    internal class Car_center
    {
        private string center_name = "no name";
        private string adress;
        private string mail_adress;
        private string owner;//влоделец
        private List<Car> cars = new List<Car>();
        public string Adress { get { return adress; } set { adress = value; } }
        public string Mail_agress { get { return mail_adress; } set { mail_adress = value; } }
        public string Owner { get { return owner; } set { owner = value; } }
        public List<Car> Cars { get { return cars; } }
        public string CenterName { get { return center_name; } }
        public void Add_car()
        {
            string manufacturer = Console.ReadLine();
            string model = Console.ReadLine();
            double price = Convert.ToDouble(Console.ReadLine());
            string color = Console.ReadLine();
            string yeat_production = Console.ReadLine();
            cars.Add(new Car(manufacturer, model, price, color, yeat_production));
        }
        public void Sell_car(int Prise, string model, string color)
        {
            int i = 0;
            foreach (var item in cars)
            {
                if (item.Price == Prise && item.Model == model && item.Color == color)
                    cars.Remove(item);
                i++;
            }
        }
        public void Max_peise_car()
        {
            double max=0;
            foreach (var item in cars)
            {
                if(item.Price > max)
                    max = item.Price;
            }
            Console.WriteLine("максимальная цена на машину"+ max);
        }
        public void Min_peise_car()
        {
            double max=999999999;
            foreach (var item in cars)
            {
                if (item.Price < max)
                    max = item.Price;
            }
            Console.WriteLine("минимальная цена на машину" + max);
        }
        public void General_info()
        {
            double sum=0;
            int i = 0;
            foreach (var item in cars)
            {
                item.Print_info();
                i++;
                sum +=item.Price;
            }
            Console.WriteLine("Количество машие в центре "+i+" общая цена "+sum);
        }

        public Car_center(string center_name, string adress, string mail_adress, string owner)
        {
            this.center_name = center_name;
            this.adress = adress;
            this.mail_adress = mail_adress;
            this.owner = owner;
        }

    }
    internal class Car
    {
        private string manufacturer;
        private string model;
        private double price;
        private string color;
        private string yeat_production;
        private Engine engine = new Engine();
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public string Model { get { return model; } set { model = value; } }
        public double Price { get { return price; } set { price = value; } }
        public string Color { get { return color; } set { color = value; } }
        public string Yeat_production { get { return yeat_production; } set { yeat_production = value; } }

        public void Print_info()
        {
            Console.WriteLine("Машина " + Manufacturer + " модель " + Model + " Цвета " + Color + " года производства" + Yeat_production);
        }
        public Car(string manufacturer, string model, double price, string color, string yeat_production)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Color = color;
            Yeat_production = yeat_production;
        }
        public Car()
        {
            Model = "no model";
            Manufacturer = "no";
            Price = 0;
            Color = "no";
            Yeat_production = "no";

        }
        ~Car()
        {
            Console.WriteLine("удалена",model);
        }
    }

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