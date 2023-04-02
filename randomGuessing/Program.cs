using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NEXT SESSION: CODE A BOT THAT WILL FIND THE NUMBER AUTOMATICALLY

namespace randomGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //START AND INPUT SECTION

            bool game = true;

            while (game)
            {

                string difficultyInput = "";
                bool pass = false;
                while (!pass)
                {
                    Console.WriteLine("GUESSING GAME\nSELECT YOUR LEVEL:\n1 - Easy[0,10] \n2 - Medium[0,100]\n3 - Hard[0, 1000]\nWrite 1, 2 or 3: ");
                    difficultyInput = Console.ReadLine();
                    if (difficultyInput == "1" || difficultyInput == "2" || difficultyInput == "3")
                    {
                        pass = true;
                    }
                }

                //INITIALIZING VARIABLES AND SETTING DIFFICULTY

                Random random = new Random();
                int randomNumber = 0;
                int trials = 0;
                int guess = 0;



                switch (difficultyInput)
                {
                    case "1":
                        randomNumber = random.Next(0, 11);
                        break;
                    case "2":
                        randomNumber = random.Next(0, 101);
                        break;
                    case "3":
                        randomNumber = random.Next(0, 1001);
                        break;
                }

                //GUESSING SECTION
                bool closeProgram = false;

                while (!closeProgram)
                {
                    Console.WriteLine("Guess: ");
                    guess = Int32.Parse(Console.ReadLine());
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Good job! You've guessed the correct number! Your trials: ", trials);
                        Console.WriteLine("1 - choose level and try again\n2 - close program");
                        bool validInput = false;

                        string endInput = "";

                        while (!validInput)
                        {
                            endInput = Console.ReadLine();
                            if (endInput == "1")
                            {
                                validInput = true;
                                closeProgram = true;
                            }
                            else if (endInput == "2")
                            {
                                validInput = true;
                                game = false;
                                closeProgram = true;
                            }
                            else
                                Console.WriteLine("Wrong input! Enter again: ");
                        }
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("The number is too great! Try again: ");
                        trials++;
                    }
                    else
                    {
                        Console.WriteLine("The number is too small! Try again: ");
                        trials++;
                    }
                }
            }
        }
    }
}
