
using System;
using System.Data.Common;
using System.Net.NetworkInformation;
using System.Net.Security;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Para";
            string guess = "";
            int guesses = 5;
            int guessLimit = 0;
            bool outOfGuesses = false;
            string answer;
            bool playAgain = true;

            Console.WriteLine("Dobro dosli u Guessing game za danasnju rec imate 5 pokusaja, posle svake greske cete dobiti novi hint koji ce vam pomoci da nadjete skrivenu rec. SRECNO!!! \n");
            Console.WriteLine("PRVI HINT - Koristi se jos iz starog Rima ");

            while (playAgain)
            {
                answer = "";

                while (guess != secretWord && !outOfGuesses && playAgain)
                {
                    guess = Console.ReadLine();

                    if (guess != secretWord)
                    {
                        guesses--;
                    }
                    else break;

                    if (guesses > guessLimit)
                    {
                                               
                        if (guesses == 4)
                        {
                            Console.WriteLine("Uuuu za malo, imate jos 4 pokusaja, sledeca pomoc je: \n");
                            Console.WriteLine("Dobija se na visokoj temperaturi vode");
                        }
                        else if (guesses == 3)
                        {
                            Console.WriteLine("Uuuu za malo, imate jos 3 pokusaja, sledeca pomoc je: ");
                            Console.WriteLine("Dosta podseca na maglu");
                        }
                        else if (guesses == 2)
                        {
                            Console.WriteLine("Uuuu za malo, imate jos 2 pokusaja, sledeca pomoc je: ");
                            Console.WriteLine(",, '' vrti gde bugrija nece");

                        }
                        else if (guesses == 1)
                        {
                            Console.WriteLine("Uuuu za malo, imate jos 1 pokusaja, sledeca pomoc je: ");
                            Console.WriteLine("\"Moze da se placa time i kod nas ima vrednost 1, 2, 5, 10, 20");

                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        
                    }
                    


                    else
                    {
                        outOfGuesses = true;
                    }

                }
                if (!outOfGuesses)
                {
                    Console.WriteLine("CESTITAMO IMAMO POBEDNIKA!!!");

                }
                else
                {
                    Console.WriteLine("Zao nam je vise srece drugi put :(");
                    Console.Write("Da li zelis da pokusas ponovo? (Y/N)");
                }

                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                    guesses = 5;
                    outOfGuesses = false;
                    Console.WriteLine("Dobija se na visokoj temperaturi vode");
                    
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.ReadKey();
        }


    }
}