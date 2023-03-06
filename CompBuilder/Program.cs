using CompBuilder.Commands;
using CompBuilder.States;

namespace CompBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			StateManager manager = new StateManager();
			manager.Run(new Configuration(manager));

			Console.ReadKey();
		}
	}
}