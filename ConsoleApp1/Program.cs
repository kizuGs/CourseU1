using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            //niekończąca się pętla
            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }



            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj " + item);
            //}


            //string name = args[1];
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxINT = " + maxInt);
            Console.WriteLine("minINT = " + minInt);
            Console.WriteLine("maxLONG = " + maxLong);
            Console.WriteLine("minLONG = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            //czeka na klawisz
            Console.ReadKey();
            //czyszczenie ekranu
            Console.Clear();
            //reset koloru
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("How old are you:");
            bool result = int.TryParse(Console.ReadLine(), out int age);


            if (age > 18)
            {
                //kolorowanie tła tekstu
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo jestes pelnoletni. Pij wodke");
            }
            else if (result == false)
            {
                Console.WriteLine("Zly wiek, popraw sie");
            }
            else
            {
                Console.WriteLine("Napij sie mleka");
            }
        }
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("What is your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name);
        }
    }
}
