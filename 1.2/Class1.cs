using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
	class Circle
	{
		private double _radius;

		public Circle(double radius)
		{
			_radius = radius;
		}
		public Circle()
		{
			//_radius = 3;
		}
		public double GetRadius()
		{
			return _radius;
		}
		public void SetRadius(double radius)
		{
			_radius = radius;
		}
		public double GetArea()
		{
			return _radius * _radius * Math.PI;
		}
		public double GetCircumference()
		{
			return  2 * Math.PI * _radius;
		}
		public string ToString()
		{
			return "Circle radius is: ";
		}
	}
}
