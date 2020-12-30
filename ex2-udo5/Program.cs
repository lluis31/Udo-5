using System;

namespace ex2_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce cuantos numeros aleatorios quieres generar:");

            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el limite inferior del rango de aleatoriedad:");

            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el limite superior del rango de aleatoriedad:");

            int max = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();

            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = r.Next(min - 1, max + 1);
                Console.WriteLine("Posición {0}: Valor {1}", i + 1, numeros[i]);
            }
        }
    }
}
