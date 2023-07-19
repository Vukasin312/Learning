using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
	internal class RandomNumber
	{
		private string _randomNumber;
		public RandomNumber()
		{
			_randomNumber = GetRandomNumber();
		}		
		public string GetRandomNumber() { return _randomNumber; }
		
		public string GenereteNumber()
		{
			Random random = new Random();
			int num = random.Next(100, 999);
			_randomNumber = num.ToString();
			return _randomNumber;
		}
    }
}
