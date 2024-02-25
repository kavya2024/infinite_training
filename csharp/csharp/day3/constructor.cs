using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program_Constructor
    {
        static void Main(string[] args)
        {
            Program_Constructor ps = new Program_Constructor();
            Loops loops = new Loops();
            loops.Do_While();
            loops.Whileloop();
            Loops.For_Loop();
            Console.Read();
        }
        public void CheckGrades()
        {
            char grades;
            int math;
            Console.WriteLine("enter your grades O/A/B/C/D");
            math = Convert.ToInt32(Console.ReadLine().ToLower());
            grades = Convert.ToChar(Console.ReadLine());
            if (grades == 'o' && math >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (grades == 'a' && math > 70 && math < 90)
            {
                Console.WriteLine("better");
            }
            else if (grades == 'b' && math > 50 && math < 70)
            {
                Console.WriteLine("good");
            }
            else if (grades == 'c' && math > 40 && math < 70)
            {
                Console.WriteLine("avarage");
            }
            else if (grades == 'd' && math < 40)
            {
                Console.WriteLine("Can Improve");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void Grade_Check_With_Switch()
        {
            char grade;
            Console.WriteLine("Enter your Grade A/B/C");
            grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'O':
                    Console.WriteLine("outstanding");
                    break;
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
            }
        }
    }
    class Loops
    {

        public void Whileloop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();
        }
        public void Do_While()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }
        public static void For_Loop()
        {
            int tot = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    break;
                tot += i;
            }
            Console.WriteLine("sum of all numbers {0}", tot);
        }
    }
}
