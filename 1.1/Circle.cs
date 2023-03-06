using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
	class Circle
	{
		private double _radius;
		private string _color;

		public Circle(double radius, string color)
		{
			_radius = radius;
			_color = color;
		}
		public Circle()
		{
			Console.WriteLine("Enter circle radius: ");
			_radius = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter circle color: ");
			_color = Console.ReadLine();
		}
		public double GetArea()
		{
			double area = _radius * _radius * Math.PI;
			return area;
		}
		public string ToString()
		{
			return "Circle[radius =" + _radius + " color = " + _color + "]";
		}
		public double GetRadius()
		{
			return _radius;
		}
		public void SetRadius(double newRadius)
		{
			this._radius = newRadius;
		}
		public string GetColor()
		{
			return _color;
		}
		public void SetColor(string newColor)
		{
			_color = newColor;
		}
	}
}
