using System;

namespace ex17_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 10;
            int[] numeros = new int[cantidad];

            for (int i =0; i < cantidad; i++)
            {
                Console.WriteLine("Escribe el valor de la posicion {0}", i + 1);

                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");
            Mostrar(numeros, cantidad);

        }
        public void Mostrar(int[] numeros, int cantidad)
        {
            for (int i =0; i < cantidad; i++)
            {
                Console.WriteLine("El valor de la posicion {0} es {1}", i + 1, numeros[i]);
            }
        }
    }
}
