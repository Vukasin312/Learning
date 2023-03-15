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
			bool biggerNumber = false;
			bool sign = true;
			int days = 0;
			int hours = 0;
			int minutes = 0;
			if (_sign == true && interval._sign == true)
			{
				days = _days + interval._days;
				hours = _hours + interval._hours;
				minutes = _minutes + interval._minutes;
			}
			else if (_sign == true && interval._sign == false)
			{
				days = _days - interval._days;
				hours = _hours - interval._hours;
				minutes = _minutes - interval._minutes;
				biggerNumber = BiggerNumber(interval);
				if (biggerNumber == true)
					biggerNumber = false;
				else
				{
					biggerNumber = true;
					sign = false;
				}
			}
			else if (_sign == false && interval._sign == true)
			{
				days = -_days + interval._days;
				hours = -_hours + interval._hours;
				minutes = -_minutes + interval._minutes;
				biggerNumber = BiggerNumber(interval);
				if (biggerNumber == true)
					sign = false;
				else
					biggerNumber = false;
			}
			else if (_sign == false && interval._sign == false)
			{
				days = _days + interval._days;
				hours = _hours + interval._hours;
				minutes = _minutes + interval._minutes;
				biggerNumber = true;
			}
			if (biggerNumber == true)
				NegativeTime(ref days, ref hours, ref minutes, ref sign);
			else
				PositiveTime(ref days, ref hours, ref minutes);
			Interval result = new Interval(days, hours, minutes, sign);
			return result;
		}

		public Interval Subtract(Interval interval)
		{
			bool biggerNumber = false;
			var sign = true;
			int days = 0;
			int hours = 0;
			int minutes = 0;
			if (_sign == true && interval._sign == true)
			{
				days = _days - interval._days;
				hours = _hours - interval._hours;
				minutes = _minutes - interval._minutes;
				biggerNumber = BiggerNumber(interval);
				if (biggerNumber == true)
					biggerNumber = false;
				else
				{
					biggerNumber = true;
					sign = false;
				}
			}
			else if (_sign == true && interval._sign == false)
			{
				days = _days + interval._days;
				hours = _hours + interval._hours;
				minutes = _minutes + interval._minutes;
				sign = true;
			}
			else if (_sign == false && interval._sign == true)
			{
				days = -_days - interval._days;
				hours = -_hours - interval._hours;
				minutes = -_minutes - interval._minutes;
				sign = false;
				biggerNumber = true;
			}
			else if (_sign == false && interval._sign == false)
			{
				days = -_days + interval._days;
				hours = -_hours + interval._hours;
				minutes = -_minutes + interval._minutes;
				biggerNumber = BiggerNumber(interval);
				if (biggerNumber == true)
					sign = false;
				else
					biggerNumber = false;
			}
			if (biggerNumber == true)
				NegativeTime(ref days, ref hours, ref minutes, ref sign);
			else
				PositiveTime(ref days, ref hours, ref minutes);
			Interval result = new Interval(days, hours, minutes, sign);
			return result;
		}

		public bool Equals(Interval interval)
		{
			if (_days == interval._days && _hours == interval._hours && _minutes == interval._minutes)
			{
				if (_days == 0 && _minutes == 0 && _hours == 0 && interval._days == 0 && interval._days == 0 && interval._days == 0)
					return true;
				else if (_sign == true && interval._sign == false)
					return false;
				else if (_sign == false && interval._sign == true)
					return false;
				else
					return true;
			}
			else
			{
				return false;
			}
		}

		public bool GreaterThan(Interval interval)
		{
			if (this._sign == true && interval._sign == false)
				return true;
			else if (this._sign == false && interval._sign == true)
				return false;
			else if (this._sign == true && interval._sign == true)
			{
				if (_days < interval._days)
					return false;
				else if (_days > interval._days)
					return true;
				else
				{
					if (_hours > interval._hours)
						return true;
					else if (_hours < interval._hours)
						return false;
					else
					{
						if (_minutes > interval._minutes)
							return true;
						else if (_minutes < interval._minutes)
							return false;
						else return false;
					}
				}
			}
			else
			{
				if (_days < interval._days)
					return true;
				else if (_days > interval._days)
					return false;
				else
				{
					if (_hours > interval._hours)
						return false;
					else if (_hours < interval._hours)
						return true;
					else
					{
						if (_minutes > interval._minutes)
							return false;
						else if (_minutes < interval._minutes)
							return true;
						else return false;
					}
				}
			}
		}

		public bool LessThan(Interval interval)
		{
			if (this._sign == true && interval._sign == false)
				return false;
			else if (this._sign == false && interval._sign == true)
				return true;
			else if (this._sign == true && interval._sign == true)
			{
				if (_days > interval._days)
					return false;
				else if (_days < interval._days)
					return true;
				else
				{
					if (_hours < interval._hours)
						return true;
					else if (_hours > interval._hours)
						return false;
					else
					{
						if (_minutes < interval._minutes)
							return true;
						else if (_minutes > interval._minutes)
							return false;
						else return false;
					}
				}
			}
			else
			{
				if (_days > interval._days)
					return true;
				else if (_days < interval._days)
					return false;
				else
				{
					if (_hours < interval._hours)
						return false;
					else if (_hours > interval._hours)
						return true;
					else
					{
						if (_minutes < interval._minutes)
							return false;
						else if (_minutes > interval._minutes)
							return true;
						else return false;
					}
				}
			}
		}

		public string Print()
		{
			char sign = '+';
			if (_sign == false)
				sign = '-';
			if (_days == 00 && _minutes == 00 && _hours == 00)
				return _hours.ToString("D2") + ":" + _minutes.ToString("D2");
			else if (_days == 00)
				return sign + _hours.ToString("D2") + ":" + _minutes.ToString("D2");
			else
				return "[" + sign + "]" + _days.ToString("D2") + ":" + _hours.ToString("D2") + ":" + _minutes.ToString("D2");
		}
		private static void PositiveTime(ref int days, ref int hours, ref int minutes)
		{
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
		}
		private static void NegativeTime(ref int days, ref int hours, ref int minutes, ref bool sign)
		{
			if (sign == false)
			{
				if (minutes >= 0 && minutes < 60)
				{
					minutes = minutes - 60;
					hours++;
				}
				if (hours >= 0 && hours < 24)
				{
					hours = hours - 24;
					days++;
				}
				if (minutes <= -60)
				{
					hours--;
					minutes += 60;
				}
				if (hours < -24)
				{
					days--;
					hours += 24;
				}
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
			days = Math.Abs(days);
			hours = Math.Abs(hours);
			minutes = Math.Abs(minutes);
			sign = false;
		}
		private bool BiggerNumber(Interval interval)
		{
			bool biggerNumber;
			if (_days < interval._days)
				biggerNumber = false;
			else if (_days > interval._days)
				biggerNumber = true;
			else
			{
				if (_hours > interval._hours)
					biggerNumber = true;
				else if (_hours < interval._hours)
					biggerNumber = false;
				else
				{
					if (_minutes > interval._minutes)
						biggerNumber = true;
					else if (_minutes < interval._minutes)
						biggerNumber = false;
					else biggerNumber = false;
				}
			}

			return biggerNumber;
		}
	}
}
