namespace _2._6
{
	internal class MyPoint
	{
		private int _x = 0;
		private int _y = 0;

		public MyPoint(int x, int y)
		{
			_x = x;
			_y = y;
		}
		public MyPoint() { }
		public int GetX() { return _x; }
		public int GetY() { return _y; }
		public void SetX(int x) { _x = x; }
		public void SetY(int y) { _y = y; }
		public int[] GetXY()
		{
			int[] xy = { _x, _y };
			return xy;
		}
		public void SetXY(int x, int y) { _x = x; _y = y; }

		public double Distance(int x, int y)
		{
			x = x - _x;
			y = y - _y;
			return Math.Sqrt(x * x + y * y);
		}
		public double Distance(MyPoint myPoint)
		{
			myPoint._x = myPoint._x - _x;
			myPoint._y = myPoint._y - _y;
			return Math.Sqrt(myPoint._x * myPoint._x + myPoint._y * myPoint._y);
		}
		public double Distance()
		{
			return Math.Sqrt(_x * _x + _y * _y);
		}

		public string Print()
		{
			return _x + " " + _y;
		}
	}
}
