namespace Program
{
	abstract class Pet
	{
		public abstract void Run();
		public abstract void Sit();
		public abstract void LieDown();
		public abstract void Display();

	}
	class Cat : Pet
	{
		private string _breed;

		public Cat(string breed)
		{
			_breed = breed;
		}

		public override void Run()
		{
			Console.WriteLine("{0} is running", _breed);
		}
		public override void Sit()
		{
			Console.WriteLine("{0} is sitting", _breed);
		}
		public override void LieDown()
		{
			Console.WriteLine("{0} is laying down", _breed);
		}
		public override void Display()
		{
			Console.WriteLine(_breed);
		}
	}
	class Dog : Pet
	{
		private string _breed;

		public Dog(string breed)
		{
			_breed = breed;
		}

		public override void Run()
		{
			Console.WriteLine("{0} is running", _breed);
		}
		public override void Sit()
		{
			Console.WriteLine("{0} is sitting", _breed);
		}
		public override void LieDown()
		{
			Console.WriteLine("{0} is laying down", _breed);
		}
		public override void Display()
		{
			Console.Write(_breed+"\n");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Pet> animals = new List<Pet>();
			animals.Add(new Dog("Husky"));
			animals.Add(new Cat("Persian"));
			while (true)
			{
				Console.WriteLine("Welcome to the pet shop, what animal do you want to chose?");
				Display(animals);
				int answer = Answer();
				switch (answer)
				{
					case 1:
						Console.WriteLine("You have successfully selected a dog," +
							" what do you want to tell him to do?");
						Console.Write("[1] Run\n [2] Lie down\n [3] Sit down\n");
						int command = Answer();
						switch (command)
						{
							case 1:
								Dog.Run();
								break;
							case 2:

								break;
							case 3:

								break;

						}
						break;
					case 2:
						Console.WriteLine("You have successfully selected a cat," +
							" what do you want to tell him to do?");
						Console.Write("[1] Run\n[2] Lie down\n[3] Sit down\n");
						command = Answer();
						switch (command)
						{
							case 1:
								Dog.Run();
								break;
							case 2:

								break;
							case 3:

								break;
						}
						break;
				}

				Console.ReadKey();
			}

			foreach (Pet pet in animals)
			{
				pet.Display();
				pet.Run();
				pet.LieDown();
				pet.Sit();
			}

			Console.ReadKey();
		}
		static void Display(List<Pet> animals)
		{
			int i = 1;
			foreach (Pet pet in animals)
			{
				Console.Write("[{0}] ", i++);
				pet.Display();
			}
		}
		static int Answer()
		{
			int answer;
			if (!int.TryParse(Console.ReadLine(), out answer))
			{
				Console.WriteLine("Please enter a valid number");
			}
			Console.WriteLine(answer);
			return answer;
		}
	}
}