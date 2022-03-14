using System;

namespace praktika_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int texmin=0;
            int yaddash;
            int deneme=0;
            Random rastgele = new Random();
            yaddash = rastgele.Next(1, 1000);
            while (texmin != yaddash)
            {
                deneme++;
                Console.WriteLine("Sayi yazin");
                texmin = Convert.ToInt16(Console.ReadLine());

                if (texmin > yaddash)
                {
                    Console.WriteLine(" Daha balaca say yazin");

                }
                else if (texmin < yaddash)
                {
                    Console.WriteLine("Daha boyuk say yazin");

                }
                else
                {
                    Console.WriteLine("Tebrikler");
                    Console.WriteLine("{0}.Yoxlamada tapdiniz", deneme);
                    Console.Read();
                }
               
               
            }
        }
        
    }
}
