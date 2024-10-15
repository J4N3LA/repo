class Employee
{
    private string _employeeName;
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        _employeeName = name;
        Salary = salary;

    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Hi my name is {_employeeName} and I earn {Salary} per year");
    }
}

public class Item
{
    protected double price;

    public Item()
    {
        price = 0;
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public virtual void calculateTotalPrice()
    {

    }
}
public class Fruit : Item
{
    private double _weightInKg;
    private double _priceOfOneKg;

    public Fruit()
        {
        //_weightInKg = w;
       // _priceOfOneKg = p;
        calculateTotalPrice();
        }

    public double  WeightInKg
    {
        get { return _weightInKg; }
        set { _weightInKg = value;
            //calculateTotalPrice();
            }
    }
    public double PriceOfOneKg
    {
        get { return _priceOfOneKg; }
        set { _priceOfOneKg = value;
            //calculateTotalPrice();
        }
    }
    public override void calculateTotalPrice()
    {
         price = _priceOfOneKg * _weightInKg;
    }
    public void calculateTotalPrice(double w, double p)
    {
         price = w * p;
         Console.WriteLine(price);
    }
}

public abstract class Bird
{
    public abstract void MakeSound();
}

public class Sparrow : Bird
{
    public override void MakeSound()
    {
        Console.WriteLine("chirp");

    }
}
public class Pigeon : Bird
{
    public override void MakeSound()
    {
        Console.WriteLine("coo");

    }
}


public class Mycollection<T>
{
    List<T> mylist = new List<T>();

    public void AddItem(T data)
    {
        mylist.Add(data);
    }
    public T GetItem(int index)
    {
        return mylist[index];
    }
}
class Program
{
    static void Main(string[] args)
    {
        int quantity = 2;
        string itemName = "Book";

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{itemName} - {i}");
        }

        Employee emp1 = new Employee("Nika", 20000);
        emp1.DisplayInfo();

        Fruit fruit1 = new Fruit();
        fruit1.calculateTotalPrice(1,5);

        Sparrow sparrow1 = new Sparrow();
        sparrow1.MakeSound();
        Pigeon pigeon1 = new Pigeon(); 
        pigeon1.MakeSound();


        Mycollection<string> mylist = new Mycollection<string>();
        mylist.AddItem("1");
        mylist.AddItem("2");
        mylist.AddItem("3");
        Console.WriteLine(mylist.GetItem(1));
    }
}