namespace _1._8
{
	internal class Time
	{
		private int _hour;
		private int _minute;
		private int _second;

		public Time(int hour, int minute, int second)
		{
			_hour = hour;
			_minute = minute;
			_second = second;
		}
		public int GetHour()
		{
			return CheckHour();
		}
		public int GetMinute()
		{
			return CheckMinute();
		}
		public int GetSecond()
		{
			return CheckSecond();
		}
		public void SetHour(int hour)
		{
			CheckHour(hour);
		}
		public void SetMinute(int minute)
		{
			CheckMinute(minute);
		}
		public void SetSecond(int second)
		{
			CheckSecond(second);
		}
		public void SetTime(int hour, int minute, int second)
		{
			_hour = hour;
			_minute = minute;
			_second = second;
		}
		public void Print()
		{
			if (_hour >= 0 && _hour <= 23 && _minute >= 0 && _minute <= 59 && _second >= 0 && _second <= 59)
			{
				string hour = _hour.ToString("D2");
				string minute = _minute.ToString("D2");
				string second = _second.ToString("D2");
				Console.WriteLine("{0}:{1}:{2}", hour, minute, second);
			}
			else
				Console.WriteLine("Invalid Time");
		}
		public Time NextSecond()
		{
			//Console.WriteLine($"{this._hour} {this._minute} {this._second}");
			_second++;
			if (_second == 60)
			{
				_second = 0;
				_minute++;
				if (_minute == 60)
				{
					_minute = 0;
					_hour++;
					if (_hour == 24)
					{
						_hour = 0;
					}
				}
			}
			return this;
		}
		private void CheckHour(int hour)
		{
			_hour = hour;
			if (_hour >= 0 && _hour <= 59)
			{
				_hour = hour;
			}
			else
				throw new Exception("Invalid time");
		}
		private void CheckMinute(int minute)
		{
			_minute = minute;
			if (_second >= 0 && _second <= 59)
			{
				_minute = minute;
			}
			else
				throw new Exception("Invalid time");
		}
		private void CheckSecond(int second)
		{
			_second = second;
			if (_second >= 0 && _second <= 59)
			{
				_second = second;
			}
			else
				throw new Exception("Invalid time");
		}
		private int CheckSecond()
		{
			if (_second >= 0 && _second <= 59)
			{
				return _second;
			}
			else
				throw new Exception("Invalid time");
			
		}
		private int CheckMinute()
		{
			if (_minute >= 0 && _minute <= 59)
			{
				return _minute;
			}
			else
				throw new Exception("Invalid time");
		}
		private int CheckHour()
		{
			if (_hour >= 0 && _hour <= 23)
			{
				return _hour;
			}
			else
				throw new Exception("Invalid time");
		}
	}
}
