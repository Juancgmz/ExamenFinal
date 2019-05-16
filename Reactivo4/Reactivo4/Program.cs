using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es para probarlo
            Console.WriteLine("Output del Selection Sort normal:");

            int[] arr2 = { 800, 1, 5, 71, 49, -10, 40, -29 };

            Classes.SelectionSort.selectionSort(arr2);

            for (int i = 0; i < arr2.Length; i++)
                Console.Write(arr2[i] + "\n");

            Console.WriteLine("\nOutput del Selection Sort con generics:");

            int[] arr = { 800, 1, 5, 71, 49, -10, 40, -29 };

            Classes.GenericSelectionSort.SelectionSort(arr);
            

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "\n");

            Console.ReadKey();
        }
    }
}
