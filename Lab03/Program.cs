using System;

namespace lab3
{
    class Person
    {
        public string name { get; set; }
        int age;
        public int setAge
        {
            set { age = value; }
        }
        public int Greet
        {
            get { return age; }
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge(int x)
        {
            Console.WriteLine($"My age is: " + x + " years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class StudentProfessorTest
    {
        string name { get; }
        public StudentProfessorTest(string _name)
        {
            name = _name;
        }
        public void Main()
        {
            Console.WriteLine("Добрий день сказав " + name);

            var student = new Student();
            student.setAge = 18;
            student.name = "Степан";
            Console.WriteLine("Привiт мене звати " + student.name + ", я студент");
            student.ShowAge(student.Greet);

            var teacher = new Professor();
            teacher.setAge = 40;
            teacher.name = "Iван";
            Console.WriteLine("Добрий день, я " + teacher.name + ", менi " + teacher.Greet + " рокiв");
            teacher.Explain();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new StudentProfessorTest("Максим");
            test.Main();
        }
    }
}
