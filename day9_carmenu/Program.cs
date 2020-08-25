using System;

namespace day9_carmenu
{
    class Program
    {
        public static void Main(string[] args)
        {


            whilemenu();


        }



        public static void whilemenu()
        {

            string userChoice;
            var Menu = new Menu();

            do
            {
                Console.Clear();
                Console.WriteLine("Auto saraksts: ");
                Console.WriteLine("1: Izvadīt sarakstu");
                Console.WriteLine("2: Pievienot auto");
                Console.Write("Izveleties menu ciparu: ");
                userChoice = Console.ReadLine();


                if (userChoice == "1")
                {
                    Menu.showlist();
                }

                if (userChoice == "2")
                {
                    Menu.addElement();
                }


                if (userChoice == "5")
                {
                    Environment.Exit(0);
                }


            } while (true);
        }
    }
}
