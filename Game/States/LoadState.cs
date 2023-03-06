using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LoadState : IState
{
	private StateManager _manager;
	private IState _lastState;

	public LoadState(StateManager manager, IState lastState)
	{
		_manager = manager;
		_lastState = lastState;
	}

	public ICommand GetCommand()
	{
		var input = Console.ReadLine();
		input = input.ToUpper();
		if (input == "BACK")
		{
			return new SwitchStateCommand(_manager, _lastState);
		}
		return new InvalidCommand();		
	}

	public void Render()
	{
		Console.WriteLine("Your load files:");
		Console.WriteLine("[Back] - go back to Main Menu");
	}
}