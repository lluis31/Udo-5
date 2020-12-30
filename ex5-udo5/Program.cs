using System;

namespace ex5_udo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero >0)
            {
                String cadena = "";
                while (numero >0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
                Console.WriteLine("Resultado en binario es: {0}", cadena);
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
            else
                {
                    Console.WriteLine("Escribs solo numeros positivos");
                }
            }
            Console.ReadLine();
        }
    }
}
