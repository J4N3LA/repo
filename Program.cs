//2
public class Shape
{
    protected double area;

    public double Area
    { get { return area; } }

    public virtual void calculateArea() { }
    

}
public class Rectangle : Shape
{
    private double length;
    private double width;

    public double Length {  
        get { return length; }
        set { length = value; calculateArea(); }
        }
    public double Width { 
        get { return width; } 
        set { width = value; calculateArea(); }
        }

    public Rectangle()
    {   
        length = 0;
        width = 0;
        calculateArea();
    }
    public override void calculateArea()
    {
        area = Length * Width;
    }
}
public class Circle : Shape
{
    double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; calculateArea(); }
    }
    public Circle()
    {
        radius = 0;
        calculateArea();
    }
    public override void calculateArea()
    {
        area = 3.14 * Radius * Radius;
    }

}

//3
class Person
{
    private int age;
    public string Name { get; set; }

    public Person(int a, string n)
    {
        age = a;
        Name = n;
    }
    public void printDetails()
    {
        Console.WriteLine($"{Name} is {age} years old");
    }
}
//4
public class DataHandler<T>
{
    public List<T> mydata = new List<T>();
    public void addData(T data)
    {
        mydata.Add(data);
    }
    public T retriveData(int i)
    {
        return mydata[i];
    }
}
//5
public interface Idevice
{
    public void activate() { }
}

public class DeviceController : Idevice
{
    public string device;
    public void activate(){ Console.WriteLine($"{device} is now actived");}
}
//6
public abstract class Vehicle
{
        public  abstract void startEngine();
        public abstract void accelerate();
}
public class Car : Vehicle
{
    public override void startEngine()
    {
        Console.WriteLine("car start");
    }
    public override void accelerate()
    {
        Console.WriteLine("car accelerate");
    }
}
public class Bike : Vehicle
{
    public override void startEngine()
    {
        Console.WriteLine("bike start"); 
    }
    public override void accelerate()
    {
        Console.WriteLine("bike pedaling");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        //1
        int myage = 22;
        double balance = 11111;
        if (balance <= 1000)
        {Console.WriteLine("This");}
        else
        {Console.WriteLine("That"); }


        Rectangle rect1 = new Rectangle();
        rect1.Width = 10;
        rect1.Length = 5;
        Console.WriteLine(rect1.Area);
        Circle circle1 = new Circle();
        circle1.Radius = 25;
        Console.WriteLine(circle1.Area);

        Person pers = new Person(22, "Nika");
        pers.printDetails();


        DataHandler<int> intList = new DataHandler<int>();
        intList.addData(1);
        intList.addData(2);     
        intList.addData(3);
        Console.WriteLine(intList.retriveData(1));

        DeviceController dev1= new DeviceController();
        dev1.device = "TV";
        dev1.activate();

        Car car = new Car();
        car.startEngine();
        car.accelerate();
        

        Bike bike = new Bike();
        bike.startEngine();
        bike.accelerate();
    }
}