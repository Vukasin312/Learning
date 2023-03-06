using CompBuilder.Abstract;
using CompBuilder.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompBuilder.States
{
	class SSD : IState
	{
		private StateManager _manager;
		private IState _lastState;

		public SSD(StateManager manager, IState lastState)
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
			Console.WriteLine("Your SSD is Aorus 4 1tb pcie 4");
			Console.WriteLine("[Back] - go back to configuration");
		}
	}
}
