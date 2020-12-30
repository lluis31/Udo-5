using System;

namespace ex15_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe cuantos numeros tiene el array");

            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            int[] numeros2 = new int[cantidad];

            for (int i = 0; i< cantidad; i++)
            {
                Console.WriteLine("Escribe el valor de la posicion {0}", i + 1);

                numeros[i] = Convert.ToInt32(Console.ReadLine());
                numeros2[cantidad - 1 - i] = numeros[i];
            }
            Console.WriteLine("");

            for (int i = 0; i< cantidad; i ++)
            {
                Console.WriteLine("Posicion {0}: valor {1}", i + 1, numeros2[i]);
            }
        }
    }
}
