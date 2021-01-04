using System;

namespace ex19_udo5
{
    class Program
    {
        
        public bool EsPrimo(int n)
        {
            bool EsPrimo = true;
            double raiz = Math.Sqrt(n);
            for (int i = 2; i <= raiz; i++)
                if ((n % i) == 0) EsPrimo = false;
            return EsPrimo;
        }

        public void Main(string[] args)
        {
            Random R = new Random();
            int ra = 0;

            Console.WriteLine("Cuantos numeros deseas generar:");
            
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            int mayor = 0;

            Console.WriteLine("Introduce el minimo del rango de aleatorios:");

            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el valor minimo del rango de aleatorios:");

            int max = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
            TryAgain:
                ra = Convert.ToInt32(R.Next(min - 1, max + 1));
                //ra = Convert.ToInt32(R);
                if (EsPrimo(ra)) { numeros[i] = ra; if (ra > mayor) { mayor = ra; } }
                else { goto TryAgain; }
            }
            Console.WriteLine("El mayor primo es {0}", mayor);


        }
    }
}
