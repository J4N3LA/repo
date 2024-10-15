
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
//1.2
public class Shape
{
    protected double area { get; set; }

    public double Area
    {
        get {  return area; }        
    }
}
public class Circle:Shape
{
    private double radius { get; set; }

    public double Radius { 
        get { return radius; }
        set { 
            radius = value;
            area = 3.14 * radius * radius;    
        }
    }

    public Circle(double r)
    {
        Radius = r;
    }
}
public class Rectangle : Shape
{
    private double length{ get; set; }
    private double width { get; set; }

    public double Lenght
    {
        get { return length;}
        set {
            length = value;
            area = length * width;
        }
    }
    public double Width
    {
        get { return width; }
        set {
            width = value;
            area = length * width;    
        }
    }
    public Rectangle(double w,double l)
    {
        Lenght = l;
        Width = w;
    }


}
//1.3
public class Person
{
    private int age;
    public string name { get; set;}


    public Person(int a,string n)
    {
        age = a;
        name = n;
    }
    public void printDetails()
    {
        Console.WriteLine($"Name : {name} Age :{age}");
    }
}
//2.1
public class DataHandler<T>
{
    private List<T> datahandler = new List<T>();

    public void addData(T data)
    {
        datahandler.Add(data);
    }
    public T retriveData(int index)
    {
        return datahandler[index];
    }
}
//2.2
interface IDevice
{
    public void activate();
}
public class DeviceController : IDevice
{
    public string device;

    public DeviceController(string dev)
    {
        device = dev;
    }
    public void activate()
    {
        Console.WriteLine($"This {device} in now active");
    }
}

//2.3
public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void Accelerate();

}

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car Engine started");
    }
    public override void Accelerate()
    {
        Console.WriteLine("Car Is accelerating");

    }
}
public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Bike is pedaling.");
    }
}
//

class Program
{
    static void Main(string[] args)
    {
        //1.1
        int myage = 22;
        double bankbalance = 111.11;
        if (bankbalance > 1000)
        {
            Console.WriteLine("This");
        }
        else
        {
            Console.WriteLine("That");
        }

        //1.2
        Rectangle rect = new Rectangle(10, 2);
        Circle circle = new Circle(4);

        Console.WriteLine(circle.Area);
        Console.WriteLine(rect.Area);

        //1.3
        Person pers = new Person(10, "Nika");
        pers.printDetails();

        //2.1
        DataHandler<int> forInt = new DataHandler<int>();
        DataHandler<string> forString = new DataHandler<string>();

        forInt.addData(1);
        forInt.addData(2);
        forInt.addData(3);
        Console.WriteLine(forInt.retriveData(1));

        //2.2
        DeviceController mydevice = new DeviceController("TV");
        mydevice.activate();

        //2.3
        Car myCar = new Car();
        myCar.StartEngine();
        myCar.Accelerate();

        Bike myBike = new Bike();
        myBike.StartEngine();
        myBike.Accelerate();
        

    }    
}



