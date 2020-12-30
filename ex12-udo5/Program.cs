using System;

namespace ex12_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Escribe el valor de la posicion {0}", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i<10; i ++)
            {
                array[0] = array[0] + array[i];
            }
            Console.WriteLine("La media es de {0}", array[0] /10);
        }
    }
}
