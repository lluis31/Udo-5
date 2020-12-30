using System;

namespace ex4_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Introduce un numero entero:");
                num = Convert.ToInt32(Console.ReadLine());
                verificar(num);
            }
            while (num < 0);
            factorial(num);
            Console.ReadKey();
        }
        static void verificar (int n)
        {
            if (n <0)
            {
                Console.WriteLine("No existeix el factorial");
            }
        }
        static void factorial (int n)
        {
            int factorial = 1;
            for (int i =1; i<= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El numero factorial de {0} es: {1}", n, factorial);
        }
    }
}
