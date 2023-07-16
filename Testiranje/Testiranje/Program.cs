class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter a number: ");
		int number = int.Parse(Console.ReadLine());

		int reverse = 0;
		int original = number;

		while (number > 0)
		{
			int digit = number % 10;
			reverse = reverse * 10 + digit;
			number /= 10;
		}

		if (original == reverse)
		{
			Console.WriteLine("The number is a palindrome.");
		}
		else
		{
			Console.WriteLine("The number is not a palindrome.");
		}
		Console.ReadKey();
	}
}