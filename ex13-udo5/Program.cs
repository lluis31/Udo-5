using System;

namespace ex13_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe cuantos numeros aleatorios del 1 al 10 quieres crear:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();

            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i ++)
            {
                numeros[i] = r.Next(0, 11);
                Console.WriteLine("Posicion {0}: valor {1}", i + 1, numeros[i]);
            }
        }
    }
}
