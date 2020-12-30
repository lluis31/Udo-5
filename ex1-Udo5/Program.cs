using System;
using System.Collections.Generic;
using System.Text;

namespace UD5Ex1al21
{
    class Ex1
    {
        public void Inicio()
        {
            double area = 0;
            int basee = 0;
            int altura = 0;
            Console.WriteLine("Que área quiere calcular: Circulo, Triangulo o Cuadrado?");
            string figura = Console.ReadLine();
            switch (figura)
            {
                case "Circulo":
                    Console.WriteLine("Introduce el radio del circulo:");
                    area = Math.PI * Math.Pow(Convert.ToInt32(Console.ReadLine()), 2);
                    break;

                case "Triangulo":
                    Console.WriteLine("Introduce la base del triangulo");
                    basee = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce la altura del triangulo:");
                    altura = Convert.ToInt32(Console.ReadLine());
                    area = basee * altura / 2;
                    break;

                case "Cuadrado":
                    Console.WriteLine("Introduce el lado del cuadrado:");
                    area = Math.Pow(Convert.ToInt32(Console.ReadLine()), 2);
                    break;
            }
            Console.WriteLine("El area de tu figura es {0}", area);
        }
    }
}