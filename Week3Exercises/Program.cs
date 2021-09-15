using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85p
            //miinimum keemias 90p
            //miinimum bioloogias 95p
            //programm küsib kasutajal sisestada eksami punktid ja otsustada kas kasutaja saab arstiks õppida


            Console.WriteLine("Sisesta oma eksami tulemus matemaatikas:");
            int Matemaatika = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma eksami tulemus keemias:");
            int Keemia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma eksami tulemus bioloogias:");
            int Bioloogia = Convert.ToInt32(Console.ReadLine());

            if(Matemaatika >= 85 && Keemia >= 90 && Bioloogia >= 95)
            {
                Console.WriteLine("Tubli, saad arstiks õppida!");
            }
            else
            {
                Console.WriteLine("Proovi järgmine aasta.");
            }







        }
    }
}
