using System;

namespace ex20_udo5
{
    class Program
    {
        public static int[] MultArray(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] * array2[i];
            }

            return array3;
        }

        public static void Ex20_udo5()
        {
            Console.WriteLine("Cuantos numeros deseas generar:");

            int cantidad = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidad];
            Random R = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = R.Next(1, 999);
            }
            int[] numeros2 = numeros;
            int[] resultado = numeros;
            numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = R.Next(1, 999);
            }
            resultado = MultArray(numeros, numeros2);

            Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", numeros));
            Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", numeros2));
            Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", resultado));
        }
    }
}
