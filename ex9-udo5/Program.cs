using System;

namespace ex9_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas posiciones quieres que tenga el array,");

            int posicion = Convert.ToInt32(Console.ReadLine());
            int[] exercici9 = new int[posicion];

            for (int i = 0; i < posicion; i++)
            {
                Console.WriteLine("Escribe el valor de la posicion {0}", i);
                exercici9[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i< posicion; i++)
            {
                Console.WriteLine("{0}", exercici9[i]);
            }
        }
    }
}
