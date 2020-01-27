using System;
using System.Collections.Generic;

namespace SuperHeroAcademy
{
    class Program
    {
        //Lista med hjältar.
        public static List<Superhero> heroes = new List<Superhero>();

        static void Main(string[] args)
        {
            //Kallar på metoden MainMenu() för att börja programmet.
            MainMenu();
            //Kallar metoden GiveName() för att namnge superhjäten.
            GiveName();

            //Skriver ut hjältens namn.
            Console.WriteLine(heroes[0].name);
            //Använder superhjältens kraft.
            Console.WriteLine(heroes[0].UsePower());


            Console.WriteLine("End");
            Console.ReadLine();
        }

        static void MainMenu()
        {
            //Instruktioner till användaren
            Console.WriteLine("Hello. Please choose a superhero to create. (type a number between 1 - 3)");
            Console.WriteLine("1. Hulk");
            Console.WriteLine("2. Spiderman");
            Console.WriteLine("3. Iron man");
            Input();
        }

        static void Input()
        {
            //Låter användaren skriva ett val.
            string input = Console.ReadLine();
            //Om svaret är gilltigt händer detta:
            if (input == "1" || input == "2" || input == "3")
            {
                //Kallar metoden Create() som skapar en hjälte, med input som parameter för att avgöra vilken av de 3 subklasserna som ska skapas.
                Superhero hero = Create(input);
                //Lägger till hjälten i listan med heroes.
                heroes.Add(hero);
            }
            //Om svaret inte är gilltigt får användaren ett felmedellande och får skriva igen.
            else
            {
                //Felmedelande.
                Console.WriteLine("Thats not a valid answer. Please try again.");
                Console.ReadLine();
                Console.Clear();
                //Kallar metoden MainMenu() igen.
                MainMenu();
            }
        }


        //Metod för att skapa en instans av en superhjälte. String type som parameter för att defienra vilken subklass som ska skapas.
        static Superhero Create(string type)
        {
            //Skapar en instans av en subklass till superhero beroende på parametern.
            //Lägger sedan till instansen i listan med superhjältar.
            if(type == "1")
            {
                Hulk hulk = new Hulk();
                return (hulk);
            }
            else if(type == "2")
            {
                Spiderman spiderman = new Spiderman();
                return (spiderman);
            }
            else
            {
                IronMan ironMan = new IronMan();
                return (ironMan);
            }
        }

        //Metod för att namnge sin superhjälte.
        static void GiveName()
        {
            Console.WriteLine("Please type a name for your hero.");
            heroes[0].name = Console.ReadLine();
        }
    }
}
