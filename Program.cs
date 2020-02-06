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

            try
            {
                const int Size = 26;

                int[] countdown = new int[Size];
                Console.WriteLine("");
                int pop_array = 0;
                for (int i = 0; i < Size; i++)
                {
                    countdown[i] = pop_array;
                    Console.WriteLine(" Element value = " + i);
                }
                Console.WriteLine("");
                Console.ReadKey(true);
            }


            catch
            {
                Console.WriteLine("Press any key to exit ...");
                Console.ReadKey(true);
            } 
            }   
        }      
    }


            
