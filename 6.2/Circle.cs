namespace Interface6._2
{
	public class Circle : IGeometricObject
	{
		private double _radius;

		public Circle(double radius)
		{
			_radius = radius;
		}

		public double GetArea()
		{
			double area = _radius * _radius * Math.PI;
			return area;
		}

		public double GetPerimeter()
		{
			double perimeter = 2* _radius*Math.PI;
			return perimeter;
		}
	}
}
