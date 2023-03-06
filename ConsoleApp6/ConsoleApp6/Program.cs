using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace Program
{
	class Program
	{

		static void Main(string[] args)
		{
			MyMethod(10);
			MyMethod(10.5);
			MyMethod(10.564f);
			MyMethod(true);

			Console.ReadKey(true);
		}

		static void MyMethod(int myInt)
		{
			Console.WriteLine("MyMethod - int " + myInt);
		}

		static void MyMethod(double mydouble)
		{
			Console.WriteLine("MyMethod - int " + mydouble);
		}

		static void MyMethod(float myfloat)
		{
			Console.WriteLine("MyMethod - int " + myfloat);
		}

		static void MyMethod(bool mybool)
		{
			Console.WriteLine("MyMethod - int " + mybool);
		}
	}
}