using System;

namespace Selectores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita un numero");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Digito 1");
                    break;
                case 2:
                    Console.WriteLine("Digito 2");
                    break;

                case 3:
                    Console.WriteLine("Digito 3");
                    break;

                case 4:
                    Console.WriteLine("Digito 4");
                    break;

                case 5:
                    Console.WriteLine("Digito 5");
                    break;

                case 6:
                    Console.WriteLine("Digito 6");
                    break;

                case 7:
                    Console.WriteLine("Digito 7");
                    break;

                case 8:
                    Console.WriteLine("Digito 8");
                    break;

                case 9:
                    Console.WriteLine("Digito 9");
                    break;

                case 10:
                    Console.WriteLine("Digito 10");
                    break;
                default:
                    Console.WriteLine("Es mayor a 10");
                    break;
            }
        }
    }
}
