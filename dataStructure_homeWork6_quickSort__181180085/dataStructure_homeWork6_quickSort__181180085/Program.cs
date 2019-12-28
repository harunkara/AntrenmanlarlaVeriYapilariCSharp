using System;

namespace dataStructure_homeWork6_quickSort__181180085
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
            Quick_Sort(array, 0, array.Length - 1);
            DateTime now = DateTime.Now;
            Console.Write("\nSorted Array:\n ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nElapsed time for sorting the array:{0}(millisecond)", now.Millisecond - then.Millisecond);
            Console.ReadKey();
        }

        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {


                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }

            }

        }
    }
}