using _2._6;

namespace _2._7
{
	internal class MyLine
	{
		private MyPoint _begin;
		private MyPoint _end;

		public MyLine(MyPoint begin, MyPoint end)
		{
			_begin = begin;
			_end = end;
		}
		public MyLine(int x1, int y1, int x2, int y2)
		{
			x1 = _begin.GetX();
			y1 = _begin.GetY();
			x2 = _end.GetX();
			y2 = _end.GetY();
		}
		public MyPoint GetBegin() { return _begin; }
		public void SetBegin(MyPoint begin) { _begin = begin; }
		public MyPoint GetEnd() { return _end; }
		public void SetEnd(MyPoint end) { _end = end; }
		public int GetBeginX() { return _begin.GetX(); }
		public void SetBeginX(int x) { _begin.SetX(x); }
		public int GetBeginY() { return _begin.GetX(); }
		public void SetBeginY(int y) { _begin.SetX(y); }
		public int GetEndX() { return _end.GetX(); }
		public void SetEndX(int x) { _end.SetX(x); }
		public int GetEndY() { return _end.GetX(); }
		public void SetEndY(int y) { _end.SetX(y); }
		public int[] GetBeginXY() { return _begin.GetXY(); }
		public void SetBeginXY(int x, int y) { _begin.SetXY(x, y);}
		public int[] GetEndXY() { return _end.GetXY(); }
		public void SetEndXY(int x, int y) { _end.SetXY(x, y); }
		public double GetLength()
		{
			int xDiff = _begin.GetX() - _end.GetX();
			int yDiff = _begin.GetY() - _end.GetY();
			return Math.Sqrt(xDiff* xDiff + yDiff * yDiff);
		}
		public double GetGradient()
		{
			int xDiff = _begin.GetX() - _end.GetX();
			int yDiff = _begin.GetY() - _end.GetY();
			return Math.Atan2(yDiff, xDiff);
		}
		public string Print()
		{
			return "MyLine[begin=(" + _begin.GetX() + ", " + _end.GetY() + "), end = (" + _end.GetX() + ", " + _end.GetY() + ")]";
		}
	}
}
