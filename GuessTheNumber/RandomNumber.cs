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
		public string GetRandomNumber() { return _randomNumber; }
		public void SetRandomNumber()
		{
			_randomNumber = GetRandomNumber();
		}
		public RandomNumber()
		{
			Random random = new Random();
			int num = random.Next(100, 999);
			_randomNumber = num.ToString();			
		}
    }
}
