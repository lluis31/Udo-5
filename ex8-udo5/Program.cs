using System;

namespace ex8_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas posiciones tiene el array:");

            int posicion = Convert.ToInt32(Console.ReadLine());
            int[] exercici8 = new int[posicion];

            for (int i = 0; i < posicion; i++)
            {
                exercici8[i] = i;
                Console.WriteLine("{0}", exercici8[i]);
            }
        }
    }
}
