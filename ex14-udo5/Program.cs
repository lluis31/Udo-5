using System;

namespace ex14_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe cuantos numeros aleatorios del 1 al 10 quieres crear:");

            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el valor a buscar:");

            int valor = Convert.ToInt32(Console.ReadLine());
            int si = 0;

            Random r = new Random();

            int[] numeros = new int[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = r.Next(0, 11);

                Console.WriteLine("Posición {0}: Valor {1}", i + 1, numeros[i]);

                if (numeros[i] == valor)
                {
                    si = 1;
                }
            }
            if (si == 1)
            {
                Console.WriteLine("El valor esta en la matriz");
            }
            else
            {
                Console.WriteLine("El valor no esta en la matriz");
            }
        }
    }
}
