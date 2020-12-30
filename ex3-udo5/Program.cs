using System;

namespace ex3_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero para saber si es primo o no:");
            int num = Convert.ToInt32(Console.ReadLine());
            int primo = calculo(num);
            if (primo == 0)
            {
                Console.WriteLine("El numero {0} es primo", num);
            }
            else
            {
                Console.WriteLine("El numero {0} no es primo", num);
            }

            int calculo(int num)
            {
                int Esprimo = 0;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Esprimo = 1;
                    }
                }
                return Esprimo;
            }
        }
    }
}
