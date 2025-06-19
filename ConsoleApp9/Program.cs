using System;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Name: {Name}";
    }
}

public class Student : Person
{
    public Student(string name) : base(name)
    {
    }

    public void Study()
    {
        Console.WriteLine("The student is studying");
    }
}

public class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }

    public void Explain()
    {
        Console.WriteLine("The teacher is explaining");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];

        Console.Write("1-talabaning ismini kiriting: ");
        string name1 = Console.ReadLine();
        people[0] = new Student(name1);

        Console.Write("2-talabaning ismini kiriting: ");
        string name2 = Console.ReadLine();
        people[1] = new Student(name2);

        Console.Write("O'qituvchining ismini kiriting: ");
        string name3 = Console.ReadLine();
        people[2] = new Teacher(name3);

        Console.WriteLine();

       
        ((Teacher)people[2]).Explain();

        ((Student)people[0]).Study();
        ((Student)people[1]).Study();
    }
}
