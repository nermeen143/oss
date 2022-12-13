using System;
namespace oop;
public abstract class Person
{
    public string Name;
    public int Age;

    public Staff(double name,int age)
    {
        Name = name;
        Age = age;
    }
    public abstract void Print();
}
public class Staff : Person
{
    public double Salary;
    public int Joinyear;

    public Student(string name,int age,double salary,int joinyear) : base(name, age)
    {
        Salary = salary;
        Joinyear = joinyear;
    }
    public override void Print()
    {
        Console.WriteLine($"My name is {Name},age{Age},salary is{Salary},join year is{Joinyear}")
    }
}
public class DB
{
    public Person[] People = new Person[50];
    public void AddStaff(Staff staff)
    {
        People[0] = staff;
    }
}

public class Program
{
    private static void Main()
    {
        Console.WriteLine("hello");
    }
}
