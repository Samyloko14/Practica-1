using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comoquiera
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma;

           
            Console.Write("Suma");
            Console.Write("\nIngrese un numero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("\nIngrese el numero 2: ");
            num2 = Int32.Parse(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("El Resultado es: " + suma);
            Console.ReadKey();
        }
    }
}
