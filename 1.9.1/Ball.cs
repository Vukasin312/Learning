namespace _1._9._1
	{
	internal class Ball
	{
		private float _x;
		private float _y;
		private int _radius;
		private int _speed;
		private int _directionInDegree;

		public Ball(float x, float y, int radius, int speed, int directionInDegree)
		{
			_x = x;
			_y = y;
			_radius = radius;
			_speed = speed;
			_directionInDegree = directionInDegree;
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
		public int GetSpeed()
		{
			return _speed;
		}
		public void SetSpeed(int speed)
		{
			_speed = speed;
		}
		public float GetDirectionInDegree()
		{
			return _directionInDegree;
		}
		public void SetDirectionInDegree(int directionInDegree)
		{
			_directionInDegree = directionInDegree;
		}
		public void MoveIQuadrant()
		{
			_x += _speed;
			_y += _speed;
		}
		public void MoveIIQuadrant()
		{
			_x += -_speed;
			_y += _speed;
		}
		public void MoveIIIQuadrant()
		{
			_x += -_speed;
			_y += -_speed;
		}
		public void MoveIVQuadrant()
		{
			_x += _speed;
			_y += -_speed;
		}
		//public void ReflectHorizontal()
		//{
		//	_xDelta = -_xDelta;
		//}
		//public void ReflectVertical()
		//{
		//	_yDelta = -_yDelta;
		//}
		public void Print()
		{
			Console.WriteLine("Ball[({0},{1}), speed = ({2},{3})", _x, _y, _xDelta, _yDelta);
		}

	}
}
