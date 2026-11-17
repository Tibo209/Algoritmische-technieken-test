using System.Security.Cryptography;

namespace Opdarcht1_bakken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int water = 4;
            int fris = 7;
            int fruit = 15;
            int bestellingen=0,combinaties=0;
            int bakken = 0;
            int minstebakken = 20;
            int jMin = 1, iMin = 1, lMin = 1;
            
            for (int i = 0; i < 120/water; i++)
            {
                for (int j = 0; j < 120/fris; j++)
                {
                    for (int l = 0; l < 120/fruit; l++)
                    {
                        combinaties++;
                        if (i != 0 && j != 0 && l != 0)
                        {
                            if ((i * water) + (j * fris) + (l * fruit) == 120)
                            {
                                bakken = i + j + l;
                                if (bakken<=20)
                                {
                                    bestellingen++;
                                    Console.WriteLine($"{i} bakken water, {j} bakken frisdrank, {l} bakken fruitsap " +
                                    $"({bakken} bakken)");
                                    if (minstebakken>bakken)
                                    {
                                        minstebakken = bakken;
                                        iMin = i; jMin = j; lMin = l;
                                    }

                                }
                               
                            }
                            
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"aantal mogelijke bestelingen: {bestellingen}");
            Console.WriteLine($"aantal combinaties getest: {combinaties}");
            Console.WriteLine($"minste bakken: {iMin} water , {jMin} frisdrank ,{lMin} fruitsap ({minstebakken} bakken)");
        }
    }
}
