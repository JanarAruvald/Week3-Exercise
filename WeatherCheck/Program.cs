using System;

namespace WeatherCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib mitu kraadi õues on
            //kui õues on rohkem kui 35 kraadi, programm kuvab "vaga palav ilm"
            //kui õues on 30 kuni 35 kraadi, programm kuvab "hot"
            //kui õues on 20 kuni 30 kraadi, programm kuvab "nice"
            //kui õues on 10 kuni 20 kraadi, programm kuvab "chilly"
            //kui õues on 0 kuni 10 kraadi, programm kuvab "freezing cold"

            Console.WriteLine("How many degrees are outside?");
            int Degree = Convert.ToInt32(Console.ReadLine());

            if(Degree >= 35)
            {
                Console.WriteLine("Boiling hot.");
            }
            else if (Degree >= 30 && Degree < 35)
            {
                Console.WriteLine("Hot.");
            }
            else if (Degree >= 20 && Degree < 30)
            {
                Console.WriteLine("Nice.");
            }
            else if (Degree >= 10 && Degree < 20)
            {
                Console.WriteLine("Cilly.");
            }
            else if (Degree >= 0 && Degree < 10)
            {
                Console.WriteLine("Cold.");
            }
            else
            {
                Console.WriteLine("Freezing cold.");
            }
        }
    }
}
