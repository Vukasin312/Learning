namespace DomaciZ1
{
	internal class TimeStamp
	{

		private int _year { get; }
		private int _month { get; }
		private int _dayInMonth { get; }
		private int _hours { get; }
		private int _minutes { get; }
		private Interval _zoneOffSet { get; }

		public TimeStamp(int year, int month, int dayInMonth, int hour, int minute, Interval zoneOffSet)
		{
			this._year = year;
			this._month = month;
			this._dayInMonth = dayInMonth;
			this._hours = hour;
			this._minutes = minute;
			_zoneOffSet = zoneOffSet;
			Exceptions();
		}

		public TimeStamp(int year, int month, int dayInMonth, Interval zoneOffSet)
		{
			this._year = year;
			this._month = month;
			this._dayInMonth = dayInMonth;
			this._hours = 0;
			this._minutes = 0;
			_zoneOffSet = zoneOffSet;
			Exceptions();
		}
		public int GetYear() { return _year; }
		public int GetMonth() { return _month; }
		public int GetDayInMonth() { return _dayInMonth; }
		public int GetHours() { return _hours; }
		public int GetMinutes() { return _minutes; }
		public TimeStamp Add(Interval interval)
		{
			var year = 0;
			var month = 0;
			var dayInMonth = 0;
			var hours = 0;
			var minutes = 0;
			if (interval.GetSign() == true)
			{
				minutes = this._minutes + interval.GetMinutes();
				hours = this._hours + interval.GetHours();
				dayInMonth = this._dayInMonth + interval.GetDays();
				month = this._month;
				year = this._year;
			}
			else
			{
				minutes = this._minutes - interval.GetMinutes();
				hours = this._hours - interval.GetHours();
				dayInMonth = this._dayInMonth - interval.GetDays();
				month = this._month;
				year = this._year;
			}
			ValidTime(ref year, ref month, ref dayInMonth, ref hours, ref minutes);

			TimeStamp result = new TimeStamp(year, month, dayInMonth, hours, minutes, _zoneOffSet);
			return result;
		}
		public TimeStamp Subtract(Interval interval)
		{
			var year = 0;
			var month = 0;
			var dayInMonth = 0;
			var hours = 0;
			var minutes = 0;
			if (interval.GetSign() == true)
			{
				minutes = this._minutes - interval.GetMinutes();
				hours = this._hours - interval.GetHours();
				dayInMonth = this._dayInMonth - interval.GetDays();
				month = this._month;
				year = this._year;
			}
			else
			{
				minutes = this._minutes + interval.GetMinutes();
				hours = this._hours + interval.GetHours();
				dayInMonth = this._dayInMonth + interval.GetDays();
				month = this._month;
				year = this._year;
			}
			ValidTime(ref year, ref month, ref dayInMonth, ref hours, ref minutes);
			TimeStamp result = new TimeStamp(year, month, dayInMonth, hours, minutes, _zoneOffSet);
			return result;
		}
		public TimeStamp SubtractTimeStamps(TimeStamp timeStamp)
		{
			var year = 0;
			var month = 0;
			var dayInMonth = 0;
			var hours = 0;
			var minutes = 0;

			year = this._year - timeStamp.GetYear();
			month = this._month - timeStamp.GetMonth();
			dayInMonth = this._dayInMonth - timeStamp.GetDayInMonth();
			hours = this._hours - timeStamp.GetHours();
			minutes = this._minutes - timeStamp.GetMinutes();

			if (minutes < 0)
			{
				minutes = minutes + 60;
				hours--;
			}
			if (hours < 0)
			{
				hours = hours + 24;
				dayInMonth--;
			}
			if (month < 0)
			{
				month = month + 12;
				year--;
			}
			if (dayInMonth < 0)
			{
				if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
					dayInMonth += 31;
				else if (month == 4 || month == 6 || month == 9 || month == 11)
					dayInMonth += 30;
				else if (month == 2 && (year % 4) == 0)
				{
					if (year % 100 == 0 && year % 400 != 0)
						dayInMonth += 28;
					else
						dayInMonth += 29;
				}
				else if (month == 2 && (year % 4) != 0)
					dayInMonth += 28;
				else if (month == 0)
					dayInMonth += 31;
				month++;
				if (month > 12)
				{
					month -= 12;
					year++;
				}
			}
			TimeStamp result = new TimeStamp(year, month, dayInMonth, hours, minutes, _zoneOffSet);
			return result;
		}

		public string Print()
		{
			return this._year + "-" + this._month + "-" + this._dayInMonth + " " + this._hours.ToString("D2") + ":" + this._minutes.ToString("D2") + " (UTC " + _zoneOffSet.Print() + ")";
		}
		private void Exceptions()
		{
			if (_year < 0)
				throw new Exception("Years cant be negatiev");
			if (_hours > 24 || _hours < 0)
				throw new Exception("Hours must be within 00-24h range");
			if (_minutes > 60 || _minutes < 0)
				throw new Exception("Minutes must be within 00-60min range");
			if (_zoneOffSet.GetHours() > 12 || _zoneOffSet.GetHours() < -12)
				throw new Exception("Zone hours must be within 12 to -12hours range");
			if (_zoneOffSet.GetMinutes() != 30 && _zoneOffSet.GetMinutes() != 0)
				throw new Exception("For zone minutes they must have value 30 or 0");
			if (_zoneOffSet.GetDays() != 0)
				throw new Exception("For zone time you cant have more than 0 days");
		}
		private void ValidTime(ref int year, ref int month, ref int dayInMonth, ref int hours, ref int minutes)
		{
			if (minutes < 0)
			{
				hours--;
				minutes += 60;
			}
			if (hours < 0)
			{
				dayInMonth--;
				hours += 24;
			}
			if (minutes >= 60)
			{
				hours++;
				minutes -= 60;
			}
			if (hours >= 24)
			{
				dayInMonth++;
				hours -= 24;
			}
			while (dayInMonth <= 0)
			{
				month--;
				SubtractDays(ref month, ref dayInMonth, ref year);
				if (month <= 0)
				{
					year--;
					month = 12;
				}
			}
			while (DayInMonthMore(ref month, ref dayInMonth, ref year) == true)
			{
				SubtractDays(ref month, ref dayInMonth, ref year);
				month++;
				while (month > 12)
				{
					year++;
					month -= 12;
				}
			}
			while (month > 12)
			{
				year++;
				month -= 12;
			}
		}
		private bool DayInMonthMore(ref int month, ref int dayInMonth, ref int year)
		{
			if (month >= 1 && month <= 12)
			{
				if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
				{
					if (dayInMonth > 31)
					{
						return true;
					}
					else return false;
				}
				else if (month == 4 || month == 6 || month == 9 || month == 11)
				{
					if (dayInMonth > 30)
					{
						return true; ;
					}
					else return false;
				}
				else if (month == 2 && (year % 4) == 0)
				{
					if (year % 100 == 0 && year % 400 != 0)
					{
						if (dayInMonth > 29)
							return true;
						else
							return false;
					}
					else if (dayInMonth > 28)
					{
						return true;
					}
					else return false;
				}
				else if (month == 2 && (year % 4) != 0)
				{
					if (dayInMonth > 28)
					{
						return true;
					}
					else return false;
				}
				else return false;
			}
			else return false;
		}
		private void SubtractDays(ref int month, ref int dayInMonth, ref int year)
		{

			if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
			{
				if (dayInMonth > 31)
					dayInMonth -= 31;
				else if (dayInMonth <= 0)
					dayInMonth += 31;
			}
			else if (month == 4 || month == 6 || month == 9 || month == 11)
			{
				if (dayInMonth > 30)
					dayInMonth -= 30;
				else if (dayInMonth <= 0)
					dayInMonth += 30;
			}
			else if (month == 2 && (year % 4) == 0)
			{
				if (year % 100 == 0 && year % 400 != 0)
				{
					if (dayInMonth > 28)
						dayInMonth -= 28;
					else if (dayInMonth <= 0)
						dayInMonth += 28;
				}
				else
				{
					if (dayInMonth > 29)
						dayInMonth -= 29;
					else if (dayInMonth <= 0)
						dayInMonth += 29;
				}
			}
			else if (month == 2 && (year % 4) != 0)
			{
				if (dayInMonth > 28)
					dayInMonth -= 28;
				else if (dayInMonth <= 0)
					dayInMonth += 28;
			}
			else if (month == 0)
			{
				dayInMonth += 31;
			}

		}
	}
}
