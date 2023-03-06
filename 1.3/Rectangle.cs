namespace _1._3
{
	class Rectangle
	{
		private float _length;
		private float _width;

		public Rectangle(float length, float width)
		{
			_length = length;
			_width = width;
		}
		public Rectangle()
		{
			_length = 1.0f;
			_width = 1.0f;
		}
		public float GetLength()
		{
			return _length;
		}
		public void SetLength(float length)
		{
			_length = length;
		}
		public float GetWidth()
		{
			return _width;
		}
		public void SetWidth(float width)
		{
			_width = width;
		}
		public float GetArea()
		{
			return _width * _length;
		}
		public float GetPerimeter()
		{
			return 2 * (_length + _width);
		}
		public string ToString()
		{
			return "Rectangle lenght is " + _length +" and width " + _width;
		}
	}
}
