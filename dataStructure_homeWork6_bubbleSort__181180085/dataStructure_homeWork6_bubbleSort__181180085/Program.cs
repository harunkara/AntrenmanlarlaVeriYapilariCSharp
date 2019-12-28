using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure_homeWork6_bubbleSort_181180085
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp1;
            int[] array = new int[100];
            int control = 0;
            Random rnd = new Random();



            for (int i = 0; i < array.Length; i++)
            {
                temp1 = rnd.Next(1, 10000);


                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == temp1)
                    {
                        control++;
                        i--;
                        break;

                    }

                }
                if (control == 0)
                {
                    array[i] = temp1;
                }
                control = 0;


            }
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\t");
            DateTime then = DateTime.Now;   
            array = bubblesort(array);
            DateTime now = DateTime.Now;
          
            Console.WriteLine("Sorted Array:");
            foreach (int p in array)
                Console.Write(p + " ");
            Console.WriteLine("\nElapsed time for sorting the array:{0}(millisecond)", now.Millisecond - then.Millisecond);
            Console.ReadKey();

        }
        static int[] bubblesort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
    }
}