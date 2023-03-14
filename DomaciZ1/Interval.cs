namespace DomaciZ1
{

    public class Interval
	{
        // Interval je nepromenljiv apstraktni tip podataka (immutable)
        // ovo mozes da stavis readonly na property
        // npr: private readonly int _days;
		// ili mozes da stavis samo da ima get bez set
		// npr: private int _days { get; }
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
		public int GetDays() { return _days; }
		public int GetHours() { return _hours; }
		public int GetMinutes() { return _minutes; }
		public bool GetSign() { return _sign; }


        // Operacija sabiranja ne sme izmeniti stanje operanada.
        // ne uzimas u obzir znak Intervala +/-
        public Interval Add(Interval interval)
		{			
			this._days += interval._days;
			this._hours += interval._hours;
			this._minutes += interval._minutes;
			if (_minutes > 60)
			{
				_hours++;
				_minutes -= 60;
			}
			if (_hours > 24)
			{
				_days++;
				_hours -= 24;
			}
			return this;
		}

        // Operacija oduzimanja ne sme izmeniti stanje operanada.
        // ne uzimas u obzir znak Intervala +/-
        public Interval Subtract(Interval interval)
		{
			this._days -= interval._days;
			this._minutes -= interval._minutes;
			this._hours -= interval._hours;
			if (_minutes < 0)
			{
				_hours--;
				_minutes += 60;
			}
			if (_hours < 0)
			{
				_days--;
				_hours += 24;
			}
			if (_days < 0)
			{
				_days = Math.Abs(_days);
				_sign = false;
			}
			return this;
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
				//Console.WriteLine("Date {0} is greather than date {1}",this , interval);
				return true;
			}
			else
			{
				//Console.WriteLine("Date {0} is not greather than date {1}",this, interval);
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
