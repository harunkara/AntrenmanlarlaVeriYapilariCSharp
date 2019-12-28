using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure_homeWork6_insertionSort__181180085
{
    class Program
    {
        static void Main(string[] args)
        {
            int temporary;
            int[] array = new int[100];
            int control = 0;
            Random rnd = new Random();



            for (int i = 0; i < array.Length; i++)
            {
                temporary = rnd.Next(1, 10000);


                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == temporary)
                    {
                        control++;
                        i--;
                        break;

                    }

                }
                if (control == 0)
                {
                    array[i] = temporary;
                }
                control = 0;


            }
            Console.Write("Array:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\t");
            DateTime then = DateTime.Now;
            array = insertionsort(array);
            DateTime now = DateTime.Now;
            Console.Write("\nSorted Array:\n ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nElapsed time for sorting the array:{0}(millisecond)", now.Millisecond - then.Millisecond);
            Console.ReadKey();
        }
        static int[] insertionsort(int[] arr)
        {
            int x, flag;
            for (int i = 1; i < arr.Length; i++)
            {
                x = arr[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (x < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = x;
                    }
                    else flag = 1;
                }



            }
            return arr;
        }

    }
}
