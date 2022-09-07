using System;

namespace uppgift_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            string elin = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            string alma = Console.ReadLine();

            int TalElin = int.Parse(elin);
            int TalAlma = int.Parse(alma);
            int skillnad = TalElin - TalAlma;

            Console.WriteLine("Elin hopppade " + skillnad + " längre än Alma");
        }
    }

}