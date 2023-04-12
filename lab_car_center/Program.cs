using lab_car_center;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
       Car_center car_Center = new Car_center("nisan","1asdas","adssds@mail.ru","OOO nisan");
        Console.WriteLine(car_Center.CenterName);
        Car a12 = new Car("Mersedes", "s20", 19000.4, "черный", "2020");
        a12.Print_info();
    }
}