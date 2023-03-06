using CompBuilder.Abstract;
using CompBuilder.Commands;

namespace CompBuilder.States
{
	class Configuration : IState
	{
		private StateManager _manager;

		public Configuration(StateManager manager)
		{
			_manager = manager;

		}
		public ICommand GetCommand()
		{
			string command = Console.ReadLine();
			command = command.ToUpper();
			if (command == "CPU")
			{
				return new SwitchStateCommand(_manager, new CPU(_manager, this));
			}
			if (command == "GPU")
			{
				return new SwitchStateCommand(_manager, new GPU(_manager, this));
			}
			if (command == "SSD")
			{
				return new SwitchStateCommand(_manager, new SSD(_manager, this));
			}
			return new InvalidCommand();
		}

		public void Render()
		{
			Console.Clear();
			Console.WriteLine("Welcome to Computer menanger there are your parts: ");
			Console.WriteLine("[CPU] - see what Proccesor you are using");
			Console.WriteLine("[GPU] - see what Graphics card you are using");
			Console.WriteLine("[SSD] - see what Solid State Drive you are using");
		}
	}
}
