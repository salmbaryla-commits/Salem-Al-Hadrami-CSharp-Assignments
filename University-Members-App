using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Student : Person
{
    public int StudentId { get; set; }

    public Student(string name, int studentId)
        : base(name)
    {
        StudentId = studentId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Student ID: " + StudentId);
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public Employee(string name, double salary)
        : base(name)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Teacher : Person
{
    public string CourseName { get; set; }

    public Teacher(string name, string courseName)
        : base(name)
    {
        CourseName = courseName;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Teacher Name: " + Name);
        Console.WriteLine("Course Name: " + CourseName);
    }
}

class Program
{
    // Method accepts Person and calls DisplayInfo()
    static void ShowPerson(Person person)
    {
        person.DisplayInfo();
    }

    static void Main(string[] args)
    {
        // Create a List<Person>
        List<Person> people = new List<Person>();

        // Create objects of each type
        Student student = new Student("Salem", 101);
        Employee employee = new Employee("Ahmed", 5000);
        Teacher teacher = new Teacher("Mohammed", "Programming");

        // Add objects to the list
        people.Add(student);
        people.Add(employee);
        people.Add(teacher);

        // Use one foreach loop
        foreach (Person person in people)
        {
            // Call DisplayInfo()
            person.DisplayInfo();

            // Print runtime type
            Console.WriteLine("Runtime Type: " + person.GetType());

            Console.WriteLine("------------------------");
        }

        // Call method that accepts Person
        Console.WriteLine("Using ShowPerson Method:");
        ShowPerson(student);
        Console.WriteLine("------------------------");

        ShowPerson(employee);
        Console.WriteLine("------------------------");

        ShowPerson(teacher);
    }
}
