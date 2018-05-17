using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ////removing the first name in the list
            //ToniList Toni = new ToniList();
            //Toni.Add("Mike");
            //Toni.Add("Toni");
            //Toni.Add("Jason");


            //Toni.PrintInfo();
            //Toni.RemoveAll("Mike");
            //Toni.PrintInfo();

            int[] numbers = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 1, 10 };


            int max = 10;

            //numbers less than 10 is compared to 10
            foreach (int number in numbers) 
            {
                if (number > max)
                {
                    max = number;
                }
            }

            int[] freq = new int[max + 1];// Defines the 11 spaces needed for the the values

            for (int i = 0; i < numbers.Length; i++)
            {

                freq[numbers[i]]++;//  The number is identified then cycled through 
                                   //  to increment the count of element occurrences.

            }

            //counts number of times element appears
            for (int i = 0; i < freq.Length; i++)
            {
                Console.WriteLine($"[{i}] occurs {freq[i]} time(s) in the array.");
            }




        }
    }
}

        
