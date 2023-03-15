namespace DomaciZ1
{

	public class Interval
	{
		private int _days { get; }
		private int _hours { get; }
		private int _minutes { get; }
		private bool _sign { get; }

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
		public int GetDays() { return _days; }
		public int GetHours() { return _hours; }
		public int GetMinutes() { return _minutes; }
		public bool GetSign() { return _sign; }

		public Interval Add(Interval interval)
		{
			var sign = true;
			int days = 0;
			int hours = 0;
			int minutes = 0;
			if (_sign == true && interval._sign == true)
			{
				days = _days + interval._days;
				hours = _hours + interval._hours;
				minutes = _minutes + interval._minutes;
			}
			if (_sign == true && interval._sign != true)
			{
				days = _days - interval._days;
				hours = _hours - interval._hours;
				minutes = _minutes - interval._minutes;
				if (this.GreaterThan(interval) != true)
					sign = false;
			}
			if (_sign != true && interval._sign == true)
			{
				days = -_days + interval._days;
				hours = -_hours + interval._hours;
				minutes = -_minutes + interval._minutes;
				if (this.GreaterThan(interval) == true)
					sign = false;

			}
			if (_sign == false && interval._sign == false)
			{
				days = -_days + -interval._days;
				hours = -_hours + -interval._hours;
				minutes = -_minutes + -interval._minutes;
				sign = false;
			}

			if (minutes >= 60)
			{
				hours++;
				minutes -= 60;
			}
			if (hours >= 24)
			{
				days++;
				hours -= 24;
			}
			if (minutes < 0)
			{
				hours--;
				minutes += 60;
			}
			if (hours < 0)
			{
				days--;
				hours += 24;
			}
			if (days < 0)
			{
				days = Math.Abs(days);
			}
			Interval result = new Interval(days, hours, minutes, sign);
			return result;
		}

		public Interval Subtract(Interval interval)
		{
			var sign = true;
			int days = 0;
			int hours = 0;
			int minutes = 0;
			if (_sign == true && interval._sign == true)
			{
				days = _days - interval._days;
				hours = _hours - interval._hours;
				minutes = _minutes - interval._minutes;
				if (this.GreaterThan(interval) != true)
					sign = false;
			}
			if (_sign == true && interval._sign != true)
			{
				days = _days - -interval._days;
				hours = _hours - -interval._hours;
				minutes = _minutes - -interval._minutes;
				if (this.GreaterThan(interval) != true)
					sign = false;
			}
			if (_sign != true && interval._sign == true)
			{
				days = -_days - interval._days;
				hours = -_hours - interval._hours;
				minutes = -_minutes - interval._minutes;
				if (this.GreaterThan(interval) != true)
					sign = false;
			}
			if (_sign == false && interval._sign == false)
			{
				days = -_days - -interval._days;
				hours = -_hours - -interval._hours;
				minutes = -_minutes - -interval._minutes;
				sign = false;
			}
			if (minutes >= 60)
			{
				hours++;
				minutes -= 60;
			}
			if (hours >= 24)
			{
				days++;
				hours -= 24;
			}
			if (minutes < 0)
			{
				hours--;
				minutes += 60;
			}
			if (hours < 0)
			{
				days--;
				hours += 24;
			}
			if (days < 0)
			{
				days = Math.Abs(days);
				sign = false;
			}
			Interval result = new Interval(days, hours, minutes, sign);
			return result;
		}

		public bool Equals(Interval interval)
		{
			if (_days == interval._days && _hours == interval._hours && _minutes == interval._minutes)
			{
				//Console.WriteLine("Two dates are equal");
				return true;
			}
			else
			{
				//Console.WriteLine("Two dates are not equal");
				return false;
			}
		}

		public bool GreaterThan(Interval interval)
		{
			bool greaterThan = true;
			if (_days < interval._days)
				greaterThan = false;
			else if (_days > interval._days)
				greaterThan = true;
			else if (_days == interval._days)
			{
				if (_hours > interval._hours)
					greaterThan = true;
				else if (_hours < interval._hours)
					greaterThan = false;
				else if (_hours == interval._hours)
				{
					if (_minutes > interval._minutes)
						greaterThan = true;
					else if (_minutes < interval._minutes)
						greaterThan = false;
					else Equals(interval);
				}
			}
			if (greaterThan is true)
			{
				//Console.WriteLine("Date {0} is greather than date {1}", this, interval);
				return true;
			}
			else
			{
				//Console.WriteLine("Date {0} is not greather than date {1}", this, interval);
				return false;
			}
		}

		public bool LessThan(Interval interval)
		{
			bool lessThan = true;
			if (_days > interval._days)
				lessThan = false;
			else if (_days < interval._days)
				lessThan = true;
			else if (_days == interval._days)
			{
				if (_hours < interval._hours)
					lessThan = true;
				else if (_hours > interval._hours)
					lessThan = false;
				else if (_hours == interval._hours)
				{
					if (_minutes < interval._minutes)
						lessThan = true;
					else if (_minutes > interval._minutes)
						lessThan = false;
					else Equals(interval);
				}
			}
			if (lessThan is true)
			{
				//Console.WriteLine("Date {0} is less than date {1}", this, interval);
				return true;
			}
			else
			{
				//Console.WriteLine("Date {0} is not less than date {1}", this, interval);
				return false;
			}
		}

		public string Print()
		{
			char sign = '+';
			if (_sign == false)
				sign = '-';
			if (_days == 00)
				return "[" + sign + "]" + _hours.ToString("D2") + ":" + _minutes.ToString("D2");
			else
				return "[" + sign + "]" + _days.ToString("D2") + ":" + _hours.ToString("D2") + ":" + _minutes.ToString("D2");
		}
	}
}
