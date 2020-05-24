using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena,cadena2,cadConcat;
            Console.WriteLine("Ingrese la cadena 1: ");
            cadena = Console.ReadLine();
            Console.WriteLine("Longitud: " + cadena.Length);
            Console.WriteLine("Letras de la cadena: "+cadena[2]+", "+cadena[5]+", "+ cadena[3] );
            Console.WriteLine("Ingrese la cadena 2: ");
            cadena2 = Console.ReadLine();
            cadConcat = cadena+cadena2;
            Console.WriteLine("Cadena concatenada: " +cadConcat );
            Console.WriteLine("Subcadena: "+cadena.Substring(3,4));
            foreach (char car in cadena)
            {
                Console.WriteLine("-" +car);
            };
            Console.WriteLine("Ingrese una palabra para buscar en la cadena: \""+cadena+"\"");
            string buscar = Console.ReadLine();
            if (cadena.Contains(buscar))
            {
                Console.WriteLine("Si contiene la palabra");
            } else
            {
                Console.WriteLine("No contiene la palabra");
            }
            if (cadena.CompareTo(cadena2)==0)
            {
                Console.WriteLine("Las cadenas 1 y 2 son iguales");
            } else
            {
                Console.WriteLine("Las cadenas 1 y 2 son distintas");
            }
            Console.WriteLine("Cadena en mayusculas: " + cadena.ToUpper());
            Console.WriteLine("Cadena en mayusculas: " + cadena.ToLower());
            int opc;
            int numA, numB;
            string ecuacion;
            Console.WriteLine("\n\n\nCALCULADORA\n");
            do
            {
                Console.WriteLine("Ingrese una ecuacion simple.");
                ecuacion = Console.ReadLine();
                if (ecuacion.Contains("+"))
                {
                    string[] nums = ecuacion.Split("+");
                    numA = Convert.ToInt32(nums[0]);
                    numB = Convert.ToInt32(nums[1]);
                    Console.WriteLine("\nLa suma de " + numA + " y " + numB + " es: " + (numA + numB));
                } else if (ecuacion.Contains("-"))
                {
                    string[] nums = ecuacion.Split("-");
                    numA = Convert.ToInt32(nums[0]);
                    numB = Convert.ToInt32(nums[1]);
                    Console.WriteLine("\nLa resta entre " + numA + " y " + numB + " es: " + (numA - numB));
                } else if (ecuacion.Contains("*"))
                {
                    string[] nums = ecuacion.Split("*");
                    numA = Convert.ToInt32(nums[0]);
                    numB = Convert.ToInt32(nums[1]);
                    Console.WriteLine("\nEl producto entre " + numA + " y " + numB + " es: " + (numA * numB));
                } else if (ecuacion.Contains("/"))
                {
                    string[] nums = ecuacion.Split("/");
                    numA = Convert.ToInt32(nums[0]);
                    numB = Convert.ToInt32(nums[1]);
                    Console.WriteLine("\nLa division entre " + numA + " y " + numB + " es: " + (numA / numB) + "\n");
                }
                Console.WriteLine("\n\n1.Volver a usar la calculadora\n0.Salir");
                Console.WriteLine("\n\nElija una opcion:");

                opc = Convert.ToInt32(Console.ReadLine());
                
            } while (opc != 0);


        }
    }
}
