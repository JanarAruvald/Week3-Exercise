using System;

namespace DateAndTimeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine(current.ToString("dd dddd, MMMM"));
            Console.WriteLine(current.ToString("MMMM"));
            Console.WriteLine(current.Year);
            

            /*DateTime current = DateTime.Now;
            Console.WriteLine(current.Month);
            Console.WriteLine(current.Year);*/
           






        }
    }
}
