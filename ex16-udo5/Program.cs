using System;

namespace ex16_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe cuantos numeros tiene el array:");

            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];

            for (int i = 0; i< cantidad; i ++)
            {
                Console.WriteLine("Escribe el valor de la posicion {0}", i + 1);

                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            int nocapicua = 0;
            for (int i =0; i < cantidad/1 && cantidad!=0; i ++)
            {
                if (numeros[i] == numeros[cantidad - 1 - i])
                {
                    nocapicua = 1;
                }
            }
            if (nocapicua != 1)
            {
                Console.WriteLine("No es capicua");
            }
            else
            {
                Console.WriteLine("Es capicua");
            }
        }
    }
}
