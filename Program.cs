//Roger Dominguez
// 2/6/2020
// Array that executes 25 elements
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            
                // Maximize array size
                const int Size = 26;

                // Populate array
                int[] countdown = new int[Size];

                Console.WriteLine("");
                int pop_array = 0;

                // Iterate array using a For loop
                for (int i = 0; i < Size; i++)
                {
                    countdown[i] = pop_array;
                    // Display message with element number
                    Console.WriteLine(" Element value = " + i);
                }
                Console.WriteLine("");
                Console.ReadKey(true);
                Console.WriteLine("Press any key to exit ...");
            
            }   
        }      
    }


            
