using Exam02;
using System.Collections;

namespace exam02
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("=======================================");
            Console.WriteLine("     1. Insert new student...");
            Console.WriteLine("     2. Dislay all the student list...");
            Console.WriteLine("     3. Calculator avenrage mark...");
            Console.WriteLine("     4. find student...");
            Console.WriteLine("     5. Exit.");
            Console.WriteLine("=======================================");


            char ch;
            Console.WriteLine("Nhap vao ky tu:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case '1':
                    Student student = new Student();

                    student.StudID = 1;
                    student.StudAge = 2;
                    student.StudClass = "class";
                    student.StudName = "StudName";
                    student.StudGender = "StudGender";

                    student.Print();
                    break;
            }
        }
    }
}