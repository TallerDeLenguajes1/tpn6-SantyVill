using System;
using System.Text.RegularExpressions;
namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex direccion = new Regex(@"\A(https?://)?([w]{3}(\.))?[a-z0-9]+(\.)(com|net|info|org)\Z");
            Regex mail = new Regex(@"\A(\w+\.?\w*)+(\@\w+)(\.)(com)\Z");
            Console.WriteLine("Ingrese una direccion web: ");
            string cad = Console.ReadLine();
            if (direccion.IsMatch(cad))
            {
                Console.WriteLine("La direccion web \""+cad+"\" es valida");
            } else
            {
                Console.WriteLine("La direccion web \"" + cad + "\" no es valida");
            }
            Console.WriteLine("\nIngrese una mail.");
            cad = Console.ReadLine();
            if (mail.IsMatch(cad))
            {
                Console.WriteLine("El mail \"" + cad + "\" es valida");
            }
            else
            {
                Console.WriteLine("El mail \"" + cad + "\" no es valida");
            }

        }
    }
}
