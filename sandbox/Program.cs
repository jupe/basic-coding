using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
           MultiplicationTable(10);

        }        
        public static void MultiplicationTable(int max)
        {
            int numero = 1;
            while (numero <= max)
            {
                PrintMultiplicationTableRow(numero, max);
                numero++;
            }

        }
        public static void PrintMultiplicationTableRow(int numero, int coefficient)
        {
            int printable = numero;
            while (printable <= numero * coefficient)
            {
                Console.Write(" " + printable);
                printable += numero;
            }
            Console.WriteLine("");
        }

    }
}
