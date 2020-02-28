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


            var studentName = new List<Student>();

            var adding  = true;

            while (adding)
            {
                Student students = new Student();
                Console.WriteLine("What is the student's name?");
                students.Name = Console.ReadLine();

                Console.WriteLine("What is the student's grade");
                students.Grade = (int.Parse(Console.ReadLine()));

                Console.WriteLine("What is the student's favorite number");
                students.FavNum = Int32.Parse(Console.ReadLine());

                Console.WriteLine("What is the student's birthday");
                students.Birthday = Console.ReadLine();

                Console.WriteLine("What is the student's phone number");
                students.Phone = Double.Parse(Console.ReadLine());

                Console.WriteLine("Add another student? y/n");

                studentName.Add(students);
                Student.Count++;//inciments the count by 1 from the student class
                Console.WriteLine("Student Count: {0}", Student.Count);//displays the static count


                string sws = Console.ReadLine();

                if ( sws.ToLower() != "y")
                {
                    adding = false;
                }
            }

            foreach (var students in studentName)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Favorite Number: {2}, Birthday: {3}", students.Name, students.Grade, students.FavNum, students.Birthday);
            }

        }
        class Student
        {
            static public int Count = 0 ;//initializing to 0 isn't necessary, but helps show that you want to start at 0.

            public string Name;
            public string Birthday;
            public int FavNum;
            private double phone;
            public int Grade;

            public double Phone
            {
                set { phone = value; Console.WriteLine("You entered the phone number: {0}",phone); }
            }


           // public void SetPhone(double number)
            //{
            //    phone = number;
           // }



        }


    }
}
   


