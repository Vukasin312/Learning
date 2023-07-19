namespace GuessTheNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GuessNumber guessNumber = new GuessNumber();
			RandomNumber randomNumber = new RandomNumber();
			NumberNotGuess numberNotGuess = new NumberNotGuess();
			string random = randomNumber.GenereteNumber();		
			Console.WriteLine(random);			
			Console.WriteLine("Please enter a number from 100-999");

			while (true)
			{
				//Console.Clear();
				string guess = guessNumber.YourGuess();

				if (guess == random)
				{
                    Console.WriteLine("Congratulation you WIN!!!");
					break;
                }
				else
				{
					string goodGuess = numberNotGuess.GoodGuess();
					Console.WriteLine(goodGuess);
					
				}
			}
				
			

			Console.ReadKey();
		}
	}
}