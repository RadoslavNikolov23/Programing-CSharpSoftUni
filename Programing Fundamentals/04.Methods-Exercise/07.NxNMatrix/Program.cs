﻿

namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            NandNMatrix(number);

        }

         static void NandNMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(number+ " ");
                }

                Console.WriteLine();
            }
        }
    }
}
