using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(100, 999);
        Console.WriteLine(randomNumber);

        Console.WriteLine("Guess a three digit number: ");
        int guess;
        bool isGuessTrue = false;
        string numberToString = randomNumber.ToString();
		int numberOfTries = 1;
        
		
		
		
		while (!isGuessTrue)
        {
			if (!int.TryParse(Console.ReadLine(), out guess))
			{
				Console.WriteLine("Please enter a number");
			}
            else
            {
                string guessToString = guess.ToString();
			
            
                if (guessToString.Equals(numberToString))
                {
                    Console.WriteLine("Congratulations");
                    if (numberOfTries== 1)
                    {
                        Console.WriteLine("You guessed on your first try !!!");
                    }
                    else
                    {
						Console.WriteLine("You guessed in " + numberOfTries + " tries");
					}
                    isGuessTrue = true;
                }
                if (guessToString.Length != 3)
                {
                    Console.WriteLine("You guess is to low or to high");
                }
                if (!guessToString.Equals(numberToString) && guessToString.Length == 3)
                {
                
                Console.Clear();
                    List<string> resultClose = new List<string>();
					List<string> resultNotClose = new List<string>();
					List<string> resultHangInThere = new List<string>();
					bool hangInThere = false;
                    bool notClose = true;
                    string result = "";
                    int index;


					for (int i = 0; i < 3; i++)
                    {
                        if (numberToString.Contains(guessToString[i]))
                        {
                            notClose = false;

                            if (!hangInThere && numberToString[i] != guessToString[i])
                            {
								resultClose.Add(guessToString);
                                resultNotClose.Add(" ");
                                resultHangInThere.Add(" ");
								for (index = 0; index < resultNotClose.Count || index < resultClose.Count || index < resultHangInThere.Count; index++)
								{
									result = ("| Not even close     |   Close      | Hang In There!|\n" +
												"|--------------------+--------------+---------------|\n" +
												"|    " + resultNotClose[index] + "             " +
												"|   " + resultClose[index] + "       " +
												"|    " + resultHangInThere[index] + "        |");
								}
							}
                            

                            if (!hangInThere && numberToString[i] == guessToString[i])
                            {
                                hangInThere = true;
                                resultHangInThere.Add(guessToString);
								resultNotClose.Add(" ");
								resultClose.Add(" ");

								for (index = 0; index < resultNotClose.Count || index < resultClose.Count || index < resultHangInThere.Count; index++)
								{
									result = ("| Not even close     |   Close      | Hang In There!|\n" +
												"|--------------------+--------------+---------------|\n" +
												"|    " + resultNotClose[index] + "             " +
												"|   " + resultClose[index] + "       " +
												"|    " + resultHangInThere[index] + "        |");
								}
							}
                        }
                    
                    }
                    if(notClose && !hangInThere)
                    {
                        resultNotClose.Add(guessToString);
                        resultClose.Add(" ");
                        resultHangInThere.Add(" ");

						for (index = 0; index < resultNotClose.Count || index < resultClose.Count || index < resultHangInThere.Count; index++)
						{
							result = ("| Not even close     |   Close      | Hang In There!|\n" +
										"|--------------------+--------------+---------------|\n" +
										"|    " + resultNotClose[index] + "             " +
										"|   " + resultClose[index] + "       " +
										"|    " + resultHangInThere[index] + "        |");
						}
					}
                    //resultNotClose.Add("");
                    //resultHangInThere.Add("");
                    

                    Console.WriteLine(result);
                    numberOfTries++;
                }
			}
		}

		Console.ReadKey();
    }
}

