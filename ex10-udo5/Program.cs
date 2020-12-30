using System;

namespace ex10_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escoge una tabla de multiplicar del 1 a 10:");

            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i< 11; i ++)
            {
                Console.WriteLine("{0}*{1}={2}", x, i, x * i);
            }
        }
    }
}
