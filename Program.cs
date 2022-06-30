using System;

namespace A2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking for quantity of elements to be put into the array
            Console.WriteLine("How many numbers do you want to add in the array?");
            int Quantity = Convert.ToInt32(Console.ReadLine());

            //declare an array with given number of indices
            int[] num = new int[Quantity];

            //input data into the array
            Console.WriteLine("\nEnter the elements of the array");

            for (int i = 0; i < Quantity; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Sorting the array in ascending order and display it.
            Array.Sort(num);

            Console.WriteLine("\n\nThese are the elements in the array (sorted in ascending order)");

            for (int i = 0; i < num.Length; i++)
            {
                
                Console.Write("  " + num[i]);
            }
            

            //print the second largest and the largest element in the array

            for (int i = num.Length-1; i < num.Length; i++)
            {
                Console.WriteLine("\n\nThe largest element is: " + num[i] + "\nThe second largest element is: " + num[i-1]);
            }
        }
    }
}
