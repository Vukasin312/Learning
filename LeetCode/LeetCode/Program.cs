using System;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode
{
	class LeetCode
	{
		static void Main(string[] args)
		{
			while (true)
			{
				int num, temp, revNum = 0, rem;
				Console.WriteLine("Enter a number: ");
				num = int.Parse(Console.ReadLine()); //45654
				temp = num;

				while (num > 0)
				{
					rem = num % 10;	//4, 5, 6, 5, 4  
					revNum = revNum * 10 + rem; //4, 45, 456, 4565, 45654 
					num = num / 10; //4565, 456, 45, 4 , 0.4
				}
				if (revNum==temp)
					Console.WriteLine("Number is Palindrome");
				else
					Console.WriteLine("Number is not a Palindrome");
			}					
			Console.ReadKey();
		}
	}
}