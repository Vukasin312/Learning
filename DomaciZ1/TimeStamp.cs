using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciZ1
{
	internal class TimeStamp
	{
		// isto kao u Interval, mora da zabranis da se menjaju vrednosti
		private int _year;
		private int _month;
		private int _day;
		private int _hour = 0;
		private int _minute = 0;
		private Interval _zoneOffSet;

		public TimeStamp(int year, int month, int day, int hour, int minute, Interval zoneOffSet)
		{
			this._year = year;
			this._month = month;
			this._day = day;
			this._hour = hour;
			this._minute = minute;
			_zoneOffSet= zoneOffSet;

			// poruke u exception, ocu da znam zasto mi ne radi
			if (_hour > 24 || _hour < 0)
				throw new Exception();
			if (_minute > 60 || _minute < 0)
				throw new Exception();
			if (_zoneOffSet.GetHours() >12 || _zoneOffSet.GetHours() < -12)
				throw new Exception();
			if (_zoneOffSet.GetMinutes() != 30 && _zoneOffSet.GetMinutes() != 0)
				throw new Exception();
			if (_zoneOffSet.GetDays() != 0)
				throw new Exception();
		}
		public TimeStamp(int year, int month, int day, Interval zoneOffSet)
		{
			this._year= year;
			this._month = month;
			this._day = day;
			this._hour = 0;
			this._minute = 0;
			_zoneOffSet = zoneOffSet;
		}
		// isto ko u interval, ne smes da menjas trenutni objekat
		// ne citas zadatak lepo :D 
		public TimeStamp Add(Interval interval)
		{
			this._day += interval.GetDays();
			this._hour += interval.GetHours();
			this._minute += interval.GetMinutes();
			if (_minute > 60)
			{
				_hour++;
				_minute -= 60;
			}
			else if (_hour > 24)
			{
				_day++;
				_hour -= 24;
			}
			return this;
		}
		public string Print()
		{
			return this._year + "-" + this._month + "-" + this._day + " " + this._hour.ToString("D2") + ":" + this._minute.ToString("D2") + " (UTC " + _zoneOffSet.Print() + ")";	
		}
	}
}
