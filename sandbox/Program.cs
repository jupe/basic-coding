using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int eka = (1+1);
            int toka = eka + 3 * (2 + 5);
            eka = 5;
            int kolmas = eka + toka;
            Console.WriteLine(eka);
            Console.WriteLine(toka);
            Console.WriteLine(kolmas);
        }
    }
}
