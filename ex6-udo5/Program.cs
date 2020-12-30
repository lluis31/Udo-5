using System;

namespace ex6_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero entero decimal:");

            int num = Convert.ToInt32(Console.ReadLine());
            int decimales = Convert.ToInt32(Math.Floor(Math.Log(num) + 1));

            Console.WriteLine("El numero {0} tiene {1} digitos", num, decimales);
        }
    }
}
