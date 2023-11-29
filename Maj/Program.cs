using System;

namespace Maj
{
    class Program
    {
        public static string maj(string carac)
        {
            string nmb;
            nmb = carac.ToUpper();

            return nmb;
        }
        static void Main(string[] args)
        {
            string nmb, carac;

            Console.WriteLine("Quels sont les caractères à mettre en majuscule : ");
            carac = Console.ReadLine();

            nmb = maj(carac);

            Console.WriteLine("Cela donne : " + nmb);
            Console.ReadLine();
        }
    }
}
