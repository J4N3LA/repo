using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Person
{
    private int age;
    public string Name { get; set; }

    public Person(int a, string n)
    {
        age = a;
        Name = n;
    }
    public void introduction()
    {
        Console.WriteLine($"Hi my name is {Name} and I am {age} years old");
    }

}

public class Shape
{
    protected double Area { get; set; }

    public Shape()
    {
        Area = 0;
    }
    public  virtual void CalculateArea()
    {
        
    }
}
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
        CalculateArea();
    }

    public double Length
    {
        get { return _length; }
        set { _length = value;
            CalculateArea();                    
        }
    }
    public double Width
    { 
        get { return _width; } 
        set { _width = value;
            CalculateArea();    
        } 
    }
    public override void CalculateArea() 
    {
        Area = _length * _width;
    }
    public void CalculateArea(double l,double w)
    {
        Area = l * w ;
    }
    public void Display()
    {
        Console.WriteLine($"Area of rectangle is {Area}");
    }

}

public class Circle :Shape
{
    double radius;
    public Circle(double rad)
    {
        radius = rad;
        CalculateArea(radius);
    }
    public void CalculateArea(double r)
    {
        Area = 3.14 * r * r;
    }
    public void Display()
    {
        Console.WriteLine($"Area of cirlce is {Area}");
    }

}
    


public abstract class Vehicle
{
    public abstract void StartEngine();
  
}
public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine($"adadad");
    }
}
public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine($"balba");
    }
}

public class mylist<T>
{
    private List<T> Thislist = new List<T>();
    public void add(T data)
    {
        Thislist.Add(data);
    }
    public T getdata(int ind)
    {
        return Thislist[ind];
    }
}
class Program
{
    static void Main(String[] args)
    {
        int age = 22;
        string name = "Nika";

        for(int i = 1; i <= 10;i++)
        {
            Console.WriteLine($"{name} - {i}");
        }


        Person pers = new Person(22, "Nika");
        pers.introduction();

        Rectangle rect = new Rectangle(3,15);
        rect.Display();
        Circle cir = new Circle(5);
        cir.Display();


        Car car = new Car();
        Bike bike = new Bike();
        car.StartEngine();
        bike.StartEngine();


            mylist<int> intlist = new mylist<int>();
            intlist.add(1);
            intlist.add(2);
            intlist.add(3);
            Console.WriteLine(intlist.getdata(1));

    }
         
}
