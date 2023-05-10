using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab_car_center
{
    internal class Car
{
    private static int cars = 0;
    private int vinnumber;
    private string manufacturer;
    private string model;
    private double price;
    private string color;
    private string yeat_production;
    private Engine engine = new Engine();
    public int VinNumber { get { return vinnumber; } }
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
        cars++;
        vinnumber = cars;
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
        Color = color;
        Yeat_production = yeat_production;
    }

    public Car(Car other)
    {
        vinnumber = other.vinnumber;
        manufacturer = other.Manufacturer;
        model = other.Model;
        price = other.Price;
        color = other.Color;
        yeat_production = other.Yeat_production;
    }

    public Car()
    {
        cars++;
        vinnumber = cars;
        Model = "no model";
        Manufacturer = "no";
        Price = 0;
        Color = "no";
        Yeat_production = "no";

    }
    ~Car()
    {
        Console.WriteLine("удалена", model);
    }
}

}
