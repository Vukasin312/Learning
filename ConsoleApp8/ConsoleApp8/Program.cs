using System.Drawing;
using System.Xml.Linq;

namespace ConsoleApp8
{
	class Engine
	{
		public void Start() { Console.WriteLine("Start engine"); }
		public void Stop() { Console.WriteLine("Stopping engine"); }
		public void Run() { Console.WriteLine("BRMMMMMM"); }

	}

	class Car
	{
		public static int NumberOfCars { get; private set; }
		public Engine Engine { get; private set; }
		public string Name { get; private set; }
		public int Age { get; private set; }
		public int Doors { get; private set; }
		public string Color { get; private set; }

		public Car(string name, int age, int doors, string color)
		{
			UpdateName(name);
			Age = age;
			Doors = doors;
			Color = color;
			Engine = new Engine();

			NumberOfCars++;
			Console.WriteLine("There are {0} cars", NumberOfCars);
		}
		
		public void Display()
		{
			Console.WriteLine("Car, name: {0}, year: {1}, Doors: {2}, Color: {3}", Name, Age, Doors, Color);
		}
		public void UpdateName(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentNullException("name");
			}
			Name = name;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Car car1 = new Car("Golf", 1992, 3, "Gray");			
			car1.Display();
			Car car2 = new Car("No name", 2003, 5, "Light Blue");
			car2.UpdateName("Passat");
			car2.Display();
			Console.ReadKey(true);
		}
	}
}