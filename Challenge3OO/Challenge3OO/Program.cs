using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenge3OO
{
    class Program
    {

        public static ClGame game = new ClGame(());

        ///1. Function Rolling Dice
        public static void RollDice()
        {
            while (true)
                {
                    Console.WriteLine("How many dice do you want to roll: ");
                    int rollAmount = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < rollAmount; i++)
                    {
                        game.AddDice();
                    }
                    game.RollAllDice();

                    Console.WriteLine("Would you like to roll again? type 'Y' or 'N'");
                    string again = Console.ReadLine().ToUpper();

                    if (again == "Y")
                    {
                        RollDice();
                    }
                    else if (again == "N")
                    {
                        return;
                    }
                    else 
                    {
                        break;
                    }
                }
        }

        ///2. Function Calculate Average + Total
        public static void Calculate()
        {
            Console.WriteLine($"Total: {game.GetTotal()}");
            Console.WriteLine($"Average: {game.GetAverage()}");
        }
        
        ///3. Function Saving List to csv File
        public static void SaveList()
        {    
            using (StreamWriter writer = new StreamWriter("./data.csv"))
            {
                foreach (var roll in game.Results)
                {
                    writer.WriteLine(roll);
                }
                Console.WriteLine("File Saved...");
            }
        }

        ///4. Function List element in Results 
        public static void List()
        {
            foreach(int roll in game.Results)
            {
                Console.WriteLine(roll);
            }
        }


        static void Main(string[] args)
        {
            ///If Existing File Exist, Load
            string path = "./data.csv";
            if (File.Exists(path))
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string line = file.ReadLine();
                    while (line != null)
                    {

                        rolls.Add(Int32.Parse(line));
                        line = file.ReadLine();
                    }
                }
            }
            bool running = true;
            while (running)
            {
                Console.WriteLine("1. Roll Dice\2. Calculate\3. Save List\4. Read Rolls\5. Exit");
            

                string Question = Console.ReadLine();

                 switch (Question)
                {
                    case "1":
                        RollDice();

                        break;
                    case "2":
                        Calculate();
                        

                        break;  
                    case "3":
                        SaveList();

                        break;
                    case "4":
                        List();

                        break;
                    case "5":
                        
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}