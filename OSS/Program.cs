using System;
namespace oop;
public abstract class Person
{
    public string Name;
    public int Age;

    public person(string name,int age)
    {
        Name = name;
        Age = age;
    }
    public abstract void Print();
}
public class Student : Person
{
    public int Year;
    public float Gpa;

    public Student(string name, int age, int year, float gpa) : base(name, age)
    {
        Year = year;
        Gpa = gpa;
    }
    public override void Print()
    {
        Console.WriteLine($"My name is {Name},age{Age},year {Year},gpa{Gpa}");
    }
}
public class Staff : Person
{
    public double Salary;
    public int Joinyear;

    public Staff(string name,int age,double salary,int joinyear) : base(name, age)
    {
        Salary = salary;
        Joinyear = joinyear;
    }
    public override void Print()
    {
        Console.WriteLine($"My name is {Name},age{Age},salary{Salary},joinyear{Joinyear}");
    }

}
public class Database
{
    private int _currntIndex;
    public Person[] People = new Person[50];
    public void AddStaff(Staff staff)
    {
        People[_currentIndex++] = staff;
    }
    public void AddStudent(Student student)
    {
        People[_currentIndex++] = student;
    }
}

public class Program
{
    private static void Main()
    {
        var database = new DB();
        int x = Convert.ToInt32(Console.ReadLine());
        if (x == 1)
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Age: ");
            var age =Convert.ToInt32( Console.ReadLine());
            Console.Write("Year: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gpa: ");
            var gpa = Convert.ToSingle(Console.ReadLine());
            var student = new Student(name, age, year, gpa);
            database.AddStudent(student);

        }
        if (x == 2)
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Age: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Salary: ");
            var salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gpa: ");
            var joinyear = Convert.ToInt32(Console.ReadLine());
            var staff = new Staff(name, age, salary, joinyear);
            database.AddStaff(staff);
        }
    }
}
