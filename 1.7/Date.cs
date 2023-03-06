namespace _1._7
{
	internal class Date
	{
		private int _day;
		private int _month;
		private int _year;

		public Date(int day, int month, int year)
		{
			_day = day;
			_month = month;
			_year = year;
			CheckDay(day);
		}
		public int GetDay()
		{
			return CheckDay();
		}
		public int GetMonth()
		{
			if (_month > 0 && _month < 13)
				return _month;
			else
				throw new Exception("Invalid date");
		}
		public int GetYear() { return _year; }
		public void SetDay(int day)
		{
			CheckDay(day);
		}
		public void SetMonth(int month)
		{
			_month = month;
		}
		public void SetYear(int year)
		{
			_year = year;
		}
		public void SetDate(int day, int month, int year)
		{
			_day = day;
			_month = month;
			_year = year;
		}
		public void Print()

		{
			string day = _day.ToString("D2");
			string month = _month.ToString("D2");
			Console.WriteLine("{0}/{1}/{2}", day, month, _year);
		}
		private void CheckDay(int day)
		{
			if (_month >= 1 && _month <= 12)
			{
				if (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)
				{
					if (_day >= 1 && _day <= 31)
					{
						_day = day;
					}
					else throw new Exception("Invalid date");
				}
				else if (_month == 4 || _month == 6 || _month == 9 || _month == 11)
				{
					if (_day >= 1 && _day <= 30)
					{
						_day = day;
					}
					else throw new Exception("Invalid date");
				}
				else if (_month == 2 && (_year % 4) == 0)
				{
					if (_day >= 1 && _day <= 29)
					{
						_day = day;
					}
					else throw new Exception("Invalid date");
				}
				else if (_month == 2 && (_year % 4) != 0)
				{
					if (_day >= 1 && _day <= 28)
					{
						_day = day;
					}
					else throw new Exception("Invalid date");
				}
				else throw new Exception("Invalid date");
			}
			else throw new Exception("Invalid date");
		}
		private int CheckDay()
		{
			if (_month >= 1 && _month <= 12)
			{
				if (_month == 1 || _month == 3 || _month == 5 || _month == 7 || _month == 8 || _month == 10 || _month == 12)
				{
					if (_day >= 1 && _day <= 31)
					{
						return _day;
					}
					else throw new Exception("Invalid date");
				}
				else if (_month == 4 || _month == 6 || _month == 9 || _month == 11)
				{
					if (_day >= 1 && _day <= 30)
					{
						return _day;
					}
					else throw new Exception("Invalid date");
				}
				else if (_month == 2 && (_year % 4) == 0)
				{
					if (_day >= 1 && _day <= 29)
					{
						return _day;
					}
					else throw new Exception("Invalid date");
				}
				else if (_month == 2 && (_year % 4) != 0)
				{
					if (_day >= 1 && _day <= 28)
					{
						return _day;
					}
					else throw new Exception("Invalid date");
				}
				else throw new Exception("Invalid date");
			}
			else throw new Exception("Invalid date");
		}
	}
}
