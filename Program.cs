// See https://aka.ms/new-console-template for more information

using BasicOOP;
namespace BasicOOP;

public class Program
{
    static Student[] students;

    static void PrintStudent(Student student)
    {
        Console.WriteLine("{0,-15}{1}", student.FirstName, student.LastName);
    }

    static void Main()
    {
        students = new Student[2];
        students[0] = new Student
        {
            FirstName = "John",
            LastName = "Johnes",
            Age = 19
        };
        students[1] = new Student
        {
            FirstName = "William",
            LastName = "Williams",
            Age = 18
        };

        PrintStudent(students[0]);
        PrintStudent(students[1]); 
    }
}