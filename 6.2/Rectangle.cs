using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface6._2
{
	internal class Rectangle : IGeometricObject
	{
		private double _width;
		private double _length;

		public Rectangle(double width, double length)
		{
			_width = width;
			_length = length;
		}

		public double GetArea()
		{
			return _width * _length;
			
		}

		public double GetPerimeter()
		{
			double perimeter = 2 * (_length + _width);
			return perimeter;
		}
	}
}
