using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Array_String
    {

        static void Main(String[] args)
        {
            Array_String array = new Array_String();
            array.Single_Dimension();
            array.Two_Dimension();
            Console.Read();


        }
        public void Single_Dimension()
        {
            Console.WriteLine("______________________________________");
            int[] arr = new int[5] { 3, 5, 6, 7, 2 };
            Console.WriteLine("The length of the array is {0}", arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(arr.Rank);
        }

        public void Two_Dimension()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public void Jagged_Array()
        {
            //1. declare jagged array of 2 row
            int[][] myjagg = new int[2][];

            // leat us now set the size for each row
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];

            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 7;
            myjagg[1][1] = 9;
            //example to initilize the jagged array in a different way
            int[][] jagg2 =
            {
                new int[]{5,3,6,8},
                new int[]{34,54},
                new int[]{43,55,66,77,79}

            };
            //to display the element of the above jagged array
            // we need two loops 
            for (int i = 0; i < jagg2.Length; i++)
            {
                Console.WriteLine("Number of Elements at row : " + i + " is" + jagg2[i].Length);
                for (int j = 0; j < jagg2[i].Length; j++)
                {
                    Console.Write(jagg2[i][j] + " ");
                }
                Console.WriteLine();

            }

        }

        public static void Switch_to_Variables()
        {
            int a = 4;
            int b = 5;
            int temp;
            Console.WriteLine("Value Stored in a before swapping: {0} in b: {1}", a, b);
            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("after swapping a : {0} and b will be : {1}", a, b);

        }
    }


}
