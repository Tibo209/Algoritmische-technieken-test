namespace Opdracht2_ControleGetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = 987654;
            int number2 = 123453;
            int number3 = 99999999;
            int number4 = 2026;
            int number5 = 7;

            Console.WriteLine($"{DigitaleWortel(number1)} ");

            Console.WriteLine($"{DigitaleWortel(number2)} ");

            Console.WriteLine($"{DigitaleWortel(number3)} ");

            Console.WriteLine($"{DigitaleWortel(number4)} ");

            Console.WriteLine($"{DigitaleWortel(number5)} ");
            
        }

        static int SomCijfers(int getal)
        {
            int som=0;
            
            // het basisgeval
            if (getal/10 <=0)
            {
                return getal;
            }

            // recursieve stap
            som = getal %10 + SomCijfers(getal/10);

            return som;
        }
        static int DigitaleWortel(int getal)
        {
            
            int cijfer = SomCijfers(getal);
            int deel;
            if (getal/10 <=0)
            {
                return SomCijfers(getal);
            }
            Console.Write($"{getal} -> ");

            deel = DigitaleWortel (cijfer);
            
            return deel;
        }
    }
}
