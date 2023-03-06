using CompBuilder.Abstract;
using CompBuilder.Commands;

namespace CompBuilder.States
{
	class CPU : IState
	{
		private StateManager _manager;
		private IState _lastState;

		public CPU(StateManager manager, IState lastState)
		{
			_manager = manager;
			_lastState = lastState;
		}
		public ICommand GetCommand()
		{
			string command = Console.ReadLine();
			command = command.ToUpper();
			if (command == "BACK")
			{
				return new SwitchStateCommand(_manager, _lastState);
			}
			return new InvalidCommand();
		}

		public void Render()
		{
			Console.Clear();
			Console.WriteLine("You proccesor is Intel I7-11700");
			Console.WriteLine("[Back] - go back to configuration");
		}
	}
}
