using System;
using System.Collections.Generic;
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public Student(string name, int age, int marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Marks: {Marks}";
    }
}
public class StudentController
{
    List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void ViewStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentController controller = new StudentController();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Student Menu ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Marks: ");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    Student s = new Student(name, age, marks);
                    controller.AddStudent(s);
                    break;

                case 2:
                    controller.ViewStudents();
                    break;

                case 3:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
        Console.WriteLine("Program Ended.");
    }
}
