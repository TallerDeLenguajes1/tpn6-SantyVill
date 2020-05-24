using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float numA,numB;
            Console.WriteLine("Ingrese un numero: ");
            numA = float.Parse(Console.ReadLine());
            if (numA<0)
            {
                Console.WriteLine("Valor absoluto: " +(numA*(-1)));
            } else
            {
                Console.WriteLine("Valor absoluto: " + numA);
            }
            Console.WriteLine("Cuadrado: " + (numA * numA));
            Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(numA));
            Console.WriteLine("Seno: " + Math.Sin(numA));
            Console.WriteLine("Coseno: " + Math.Cos(numA));
            Console.WriteLine("Parte entera: " + Convert.ToInt32(numA));
            Console.WriteLine("\nIngrese un numero A: ");
            numA = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero B: ");
            numB = float.Parse(Console.ReadLine());
            if (numA>numB)
            {
                Console.WriteLine("El mayor es "+numA+" y el menor es "+numB+".");
            } else
            {
                Console.WriteLine("El mayor es " + numB + " y el menor es " + numA + ".");
            }

        }
    }
}
