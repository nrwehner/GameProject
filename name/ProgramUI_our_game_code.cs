using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace name
{
    public class ProgramUI
    {
        bool isPlayingGame = true;
        public void run()
        {
            while (isPlayingGame)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   ______                             \n"+
"  / ____/ ____ _ ____ ___   ___   _____\n"+
@" / /  __ / __ `// __ `__ \ / _ \ / ___/"+"\n"+
"/ /_ / // /_/ // / / / / //  __/(__  ) \n"+
@"\____ / \__,_//_/ /_/ /_/ \___//____/  "+"\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to Andrea and Nick's Games!\n" +
                "\n"+
                "Pick a game to play below (enter 1 through 5)\n" +
                "\n"+
                "1) Mad Lib at the Beach\n" +
                "2) Mad Lib at Work\n" +
                "3) Mad Lib at a Party\n" +
                "4) Watch a Train Animation\n" +
                "5) Heads or Tails Game\n"+
                "6) Exit");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    BeachGame();
                    break;
                case "2":
                    WorkGame();
                    break;
                case "3":
                    PartyGame();
                    break;
                case "4":
                    TrainAnimation();
                    break;
                case "5":
                    HeadsOrTailsGame();
                    break;
                case "6":
                    isPlayingGame = false;
                    break;
                default:
                        Console.WriteLine("That is an invalid response. Prese any key to continue, and then provide a number 1 through 6.");
                        Console.ReadKey();
                    break;
            }
            }

        }
        private void BeachGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Beach Mad Lib Game!  We are so glad you are here!\n" +
                "\n"+
                "Give us a name, any name.\n");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us a verb (past tense).\n");
            string pastTenseVerb = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us a color.\n");
            string color = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us an object you would bring to the beach.\n");
            string beachObject = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us a type of person you might not see at the beach (ie mountain climber).\n");
            string strangePerson = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us a food item.\n");
            string foodItem = Console.ReadLine();


            Console.Clear();
            Console.Write("Great, thank you. Here is your mad lib result:\n" +
                "\n" +
                "So, it was a beautiful sunny day at ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[{name}]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Beach. The dolpins were singing and the kids were playing, and it was great!\n" +
                "Suddenly, a(n) ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[{color}]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" bird decided to fly up toward us.  The bird then stole our ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[{foodItem}]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(". You then had the bright idea to use a(n) \n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[{beachObject}]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to shoo the bird away!  It didn't work.\n" +
                "\n"+
                "So the bird harrassed us all day, until finally a(n) ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[{strangePerson}]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" showed up, captured the bird and vanished!\n" +
                "\n"+
                "Now that the bird was gone, we went back to having fun and ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"[{pastTenseVerb}]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the rest of the day!\n"+
                "\n");
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
        }
        private void WorkGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Work Mad Lib Game!  We are so glad you are here!\n" +
                "\n" +
                "Whats your occupation?\n");
            string occupation = Console.ReadLine();
            Console.Clear();
            Console.Write("Give us a verb (ending in ING).\n");
            string verb = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us a color.\n");
            string color = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us an object you use at work.\n");
            string workObject = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us an unusual weather event.\n");
            string weather = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Give us a coworkers name.\n");
            string coworkerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Fantastic! Check out your mad lib here \n" +
                $"\n" +
                $"Another Wonderful Monday as a(n) {occupation}! \n" +
                $"You step into the office to see your not so favorite coworker {coworkerName} wearing a(n) {color} suit.\n" +
                $" the day continues, as they tend to do and you look out your window to see a(n) {weather}. Everyone is {verb} in fear.\n" +
                $" You decide to leave for the day. Outside, you see a(n) {workObject} flying through the air. What a day!\n" + "\n");
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();

        }
        private void PartyGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Party Mad Lib Game!  We are so glad you are here!\n" +
                "\n" +
                "Give us a U.S. city, a ING verb, a celebrity name, an animal, a sport, and fruit (each separated by a comma).\n");
            string userAnswers = Console.ReadLine();
            string[] answerArray = userAnswers.Split(',');
            int arrayCount = answerArray.Length;
            if (answerArray.Length == 6)
            {
                Console.Clear();
            Console.WriteLine("Fantastic! Check out your mad lib here \n" +
                $"\n" +
                $"This weekend we went to the party of the century in none other than [{answerArray[0]}]! Hottest city in the country, if you ask me.\n" +
                $"We were dancing the night away, and a little bit of [{answerArray[1]}] as well, when suddenly we realized that [{answerArray[2]}] was at the party!\n" +
                $" [{answerArray[2]}] was holding a(n) [{answerArray[3]}] and then they started playing [{answerArray[4]}]. Everyone started watching in awe.\n" +
                $" After the game was over [{answerArray[2]}] and the [{answerArray[3]}] started handing out a(n) [{answerArray[5]}] to everyone.  What a party!\n");
            }
            else
            {
                Console.WriteLine("you did something wrong. You needed to provide 6 answers, separated by commas.\n");
            }
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();

        }
        static void TrainAnimation()
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        Console.Clear();
                        // steam
                        Console.Write("       . . . . o o o o o o");
                        for (int s = 0; s < j / 2; s++)
                        {
                            Console.Write(" o");
                        }
                        Console.WriteLine();
                        var margin = "".PadLeft(j);
                        Console.WriteLine(margin + "                _____      o");
                        Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.");
                        Console.WriteLine(margin + "      [________]_|__|________)< ");
                        Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_");
                        Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+");
                        Thread.Sleep(200);
                    }
                }
            Console.WriteLine("press any key to continue...\n");
            Console.ReadKey();
            }
        private void HeadsOrTailsGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Heads or Tails Game!\n" +
                "\n" +
                "Please enter heads or tails.\n");
            string headsOrTailsUser = Console.ReadLine();
            if(headsOrTailsUser!="heads" && headsOrTailsUser != "tails")
            {
                Console.WriteLine("You did not provide either heads or tales. press any key to continue.\n");
                Console.ReadKey();
            }
            else
            {
            Random random = new Random();
            int randomNumber = random.Next(1, 3);
            string headsOrTailsAnswer = (randomNumber == 1) ? "heads" : "tails";
            Console.WriteLine((headsOrTailsUser == headsOrTailsAnswer) ? $"You are correct! The coin came up {headsOrTailsAnswer} and you guessed {headsOrTailsUser}.\n"
                : $"You are incorrect.  The coin came up {headsOrTailsAnswer} and you guessed {headsOrTailsUser}.\n");
            Console.WriteLine("\n"+"press any key to continue\n");
            Console.ReadKey();
            }
        }
    }
}
