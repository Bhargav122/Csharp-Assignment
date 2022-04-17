
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            // Creating an array  
            int[] arr = new int[6] { 5,20,10,8,1,50 };
            // Creating an empty array  
            int[] arr2 = new int[6];
            string[] arr3 = new string[3] 
            { 
                "Korrai", "Bhargav", "KB"
            };
            Console.Write("string array elements: ");
            PrintStr(arr3);
            Array.Clear(arr3, 0, 2);
            Console.Write("\nstring Array elements after clear of two values: ");
            PrintStr(arr3);
            Console.Write("\nFirst array elements: ");
            PrintArray(arr);
            //Console.WriteLine("\nlength of first array: " + arr.Length);
            //Sorting
            Array.Sort(arr);
            Console.Write("\nSorted array elements: ");
            PrintArray(arr);
            // Coping first array to empty array  
            Array.Copy(arr, arr2, arr.Length);
            Console.Write("\ncopied array elements: ");
            // Displaying second array  
            PrintArray(arr2);
            //reverse
            Array.Reverse(arr);
            Console.Write("\nArray elements in reverse order: ");
            PrintArray(arr);
            //clear
            Array.Clear(arr, 0, 3);
            Console.Write("\nArray elements in after clear of three values: ");
            PrintArray(arr);
        }
        // User defined method for iterating array elements  
        static void PrintArray(int[] arr)
        {
            foreach (Object elements in arr)
            {
                Console.Write(elements + " ");
            }
        }
        static void PrintStr(string[] arr)
        {
            foreach (Object elements in arr)
            {
                Console.Write(elements + " ");
            }
        }
    }
}