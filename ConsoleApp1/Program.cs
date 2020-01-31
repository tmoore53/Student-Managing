using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("How many students are in your class? ");
            //var classCount = int.Parse(Console.ReadLine());

            //var studentName = new string[classCount];
            //var studentGrades = new int[classCount];


            var student = new List<Student>();


            var answer = true;

            while(answer)
            {
                var students = new Student();
                Console.WriteLine("What is the student's name?");
                students.Name  = Console.ReadLine();
                Console.WriteLine("What is the student's grade");
                students.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Add another student? y/n");

                student.Add(students);
                
                if (Console.ReadLine() != "y")
                {
                    answer = false;
                }
            
               
            }


            foreach (var students in student ) 
            {
                Console.WriteLine("Name: {0}, Grade: {1}", students.Name, students.Grade);
                    
            }
            
            //for (int i = 0; i < student.Count; i++)
            //{
            //    Console.WriteLine("Name: {0}, Grade: {1}",student[i], student[i]);
            //}

        }
        class Student
        {
            public string Name;
            public string Birthday;
            public int Age;
            public int Phone;
            public int Grade;

        }
    }
}
