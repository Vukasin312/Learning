namespace _1._9
{
	internal class Ball
	{
		private float _x;
		private float _y;
		private int _radius;
		private float _xDelta;
		private float _yDelta;

		public Ball(float x, float y, int radius, float xDelta, float yDelta)
		{
			_x = x;
			_y = y;
			_radius = radius;
			_xDelta = xDelta;
			_yDelta = yDelta;
		}
		public float GetX()
		{
			return _x;
		}
		public void SetX(float x)
		{
			_x = x;
		}
		public float GetY()
		{
			return _y;
		}
		public void SetY(float y)
		{
			_y = y;
		}
		public int GetRadius()
		{
			return _radius;
		}
		public void SetRadius(int radius)
		{
			_radius = radius;
		}
		public float GetXDelta()
		{
			return _xDelta;
		}
		public void SetXDelta(float _xDealta)
		{
			_xDelta = _xDealta;
		}
		public float GetYDelta()
		{
			return _yDelta;
		}
		public void SetYDelta(float _yDealta)
		{
			_yDelta = _yDealta;
		}
		public void Move()
		{
			_x += _xDelta;
			_y += _yDelta;
		}
		public void ReflectHorizontal()
		{
			_xDelta = -_xDelta;
		}
		public void ReflectVertical()
		{
			_yDelta = -_yDelta;
		}
		public void Print()
		{
			Console.WriteLine("Ball[({0},{1}), speed = ({2},{3})", _x, _y, _xDelta, _yDelta);
		}

	}
}
