using System;

class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Name = name;
        Email = email;

        Console.WriteLine("Person constructor");
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
    }
}

class Student : Person
{
    public int StudentId;
    public double GPA;

    public Student(string name, string email, int studentId, double gpa)
        : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;

        Console.WriteLine("Student constructor");
    }
}

class Employee : Person
{
    public int EmployeeId;
    public double Salary;

    public Employee(string name, string email, int employeeId, double salary)
        : base(name, email)
    {
        EmployeeId = employeeId;
        Salary = salary;

        Console.WriteLine("Employee constructor");
    }
}

class Teacher : Employee
{
    public string CourseName;

    public Teacher(
        string name,
        string email,
        int employeeId,
        double salary,
        string courseName)
        : base(name, email, employeeId, salary)
    {
        CourseName = courseName;

        Console.WriteLine("Teacher constructor");
    }

    public void Teach()
    {
        Console.WriteLine("Teaching course: " + CourseName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(
            "Salem",
            "salem@gmail.com",
            101,
            3.5
        );

        Console.WriteLine();

        Teacher teacher1 = new Teacher(
            "Ahmed",
            "ahmed@gmail.com",
            501,
            1500,
            "C# Programming"
        );

        Console.WriteLine();

        Console.WriteLine("Student Information:");
        student1.DisplayBasicInfo();

        Console.WriteLine();

        Console.WriteLine("Teacher Information:");
        teacher1.DisplayBasicInfo();
        teacher1.Teach();
    }
}
