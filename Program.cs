using System;

namespace gissa_spel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump=new Random();
            int rand = slump.Next(100);
            int tries = 0;
            Console.WriteLine("Gissa ett tal:");
            int num=int.Parse(Console.ReadLine());
            while (num != rand)
            {
               if (num < rand)
               {
                   Console.WriteLine("Gissningen är för låg");
               } 
               if (num > rand)
               {
                   Console.WriteLine("Gissningen är för hög");
               }
               Console.WriteLine("Gissa ett tal:");
               num=int.Parse(Console.ReadLine());
               tries += 1;
            }
            Console.WriteLine("Det är rätt tal");
            Console.WriteLine("Antal försök är " + tries);

        }
    }
}
