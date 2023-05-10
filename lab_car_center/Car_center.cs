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
        private string owner;//владелец
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

}