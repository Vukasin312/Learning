namespace DomaciZ1
{
	internal class Interval
	{
		private int _days;
		private int _hours;
		private int _minutes;
		private bool _sign;

		public Interval(int days, int hours, int minutes, bool sign)
		{
			_days = days;
			_hours = hours;
			_minutes = minutes;
			_sign = sign;
			if (_hours > 24 || _hours < 0)
				throw new Exception();
			if (_minutes > 60 || _minutes < 0)
				throw new Exception();
		}
		public int GetDays(int days) { return _days; }
		public int GetHours(int hours) { return _hours; }
		public int GetMinutes(int minutes) { return _minutes; }
		public bool GetSign(bool sign) { return _sign; }
		public Interval Add(Interval left, Interval right)
		{
			int day = left.GetDays(_days);
			int hour = left.GetHours(_hours);
			int minutes = left.GetMinutes(_minutes);
			int day1 = right.GetDays(_days);
			int hour1 = right.GetHours(_hours);
			int minutes1 = right.GetMinutes(_minutes);

			_days = day + day1;
			_hours = hour + hour1;
			_minutes = minutes + minutes1;
			if (_minutes > 60)
			{
				_hours++;
				_minutes = _minutes - 60;
			}
			else if (_hours > 24)
			{
				_days++;
				_hours = _hours - 24;
			}
			return this;
		}
		public Interval Substract(Interval left, Interval right)
		{
			int day = left.GetDays(_days);
			int hour = left.GetHours(_hours);
			int minutes = left.GetMinutes(_minutes);
			int day1 = right.GetDays(_days);
			int hour1 = right.GetHours(_hours);
			int minutes1 = right.GetMinutes(_minutes);

			_days = day - day1;
			_hours = hour - hour1;
			_minutes = minutes - minutes1;
			if (_minutes < 0)
			{
				_hours--;
				_minutes = _minutes + 60;
			}
			if (_hours < 0)
			{
				_days--;
				_hours = _hours + 24;
			}
			if (_days < 0)
			{
				_days = Math.Abs(_days);
				_sign = false;
			}
			return this;
		}
		public bool Equals(Interval left, Interval right)
		{
			int day = left.GetDays(_days);
			int hour = left.GetHours(_hours);
			int minutes = left.GetMinutes(_minutes);
			int day1 = right.GetDays(_days);
			int hour1 = right.GetHours(_hours);
			int minutes1 = right.GetMinutes(_minutes);

			if (day == day1 && hour == hour1 && minutes == minutes1)
			{
				Console.WriteLine("Two dates are equal");
				return true;
			}
			else
			{
				Console.WriteLine("Two dates are not equal");
				return false;
			}
		}
		public bool GreaterThan(Interval left, Interval right)
		{
			bool lessThan = true;
			int day = left.GetDays(_days);
			int hour = left.GetHours(_hours);
			int minutes = left.GetMinutes(_minutes);
			int day1 = right.GetDays(_days);
			int hour1 = right.GetHours(_hours);
			int minutes1 = right.GetMinutes(_minutes);

			if (day < day1)
				lessThan = false;
			else if (day > day1)
				lessThan = true;
			else if (day == day1)
			{
				if (hour > hour1)
					lessThan = true;
				else if (hour < hour1)
					lessThan = false;
				else if (hour == hour1)
				{
					if (minutes > minutes1)
						lessThan = true;
					else if (minutes < minutes1)
						lessThan = false;
					else Equals(left, right);
				}
			}
			if (lessThan is true)
			{
				Console.WriteLine("Date {0} is greather than date {1}", left, right);
				return true;
			}
			else
			{
				Console.WriteLine("Date {0} is not greather than date {1}", left, right);
				return true;
			}
		}
		public void Render()
		{
			string days = _days.ToString("D2");
			string hours = _hours.ToString("D2");
			string minutes = _minutes.ToString("D2");
			char sign = '+';
			if (_sign == false)
				sign = '-';
			if (days == "00")
				Console.WriteLine("[{2}]{0}:{1}", hours, minutes, sign);
			else
				Console.WriteLine("[{3}]{0}:{1}:{2}", days, hours, minutes, sign);
		}		
	}
}
