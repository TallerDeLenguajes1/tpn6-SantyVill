using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,numInv=0;
            Console.WriteLine("Ingrese un numero: ");
            num =Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                while (num>0)
                {
                    numInv = numInv*10 + num % 10;
                    num = num / 10;
                }
            }
            Console.WriteLine("Numero invertido: " + numInv);
        }
    }
}
