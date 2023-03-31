using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många hetal vill du skriva in? ");
            int AntalHeltal=Convert.ToInt32(Console.ReadLine());

            int[] Heltal=new int[AntalHeltal];

            Console.WriteLine("Skriv in " + AntalHeltal + " heltal");

            for (int i = 0; i < AntalHeltal; i++)
            {
                //Console.Write("Tal " + (i + 1) + " : ");
                Heltal[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(Heltal);
            Console.WriteLine("Talen i Storleksordning:");

            for(int i = 0; i < Heltal.Length; i++)
            {
                Console.WriteLine("Tal " +(i+1)+" : "+Heltal[i]);   

            }

        }
    }
}
