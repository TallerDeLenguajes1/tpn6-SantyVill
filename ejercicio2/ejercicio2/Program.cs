using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc,numA,numB;
            do
            {
                Console.WriteLine("\n\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n0.Salir");
                Console.WriteLine("\n\nElija una opcion:");

                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese dos numeros para realizar la suma.");
                        Console.WriteLine("A: ");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("B: ");
                        numB = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nResultado: " + (numA+numB));
                        break;
                    case 2:
                        Console.WriteLine("Ingrese dos numeros para realizar la resta");
                        Console.WriteLine("A: ");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("B: ");
                        numB = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nResultado: " + (numA-numB));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese dos numeros para realizar la multiplicacion");
                        Console.WriteLine("A: ");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("B: ");
                        numB = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nResultado: " + (numA*numB));
                        break;
                    case 4:
                        Console.WriteLine("Ingrese dos numeros para ralizar la division");
                        Console.WriteLine("Dividendo: ");
                        numA = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Divisor: ");
                        numB = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nResultado: " + (numA/numB)+ "\n");
                        break;
                    default:
                        Console.WriteLine("\nOpcion no valida.");
                        break;
                };

            } while (opc != 0);

        }
    }
}
