using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainMenuState : IState
{
	private StateManager _menager;

	public MainMenuState(StateManager menager)
	{
		_menager = menager;
	}
	public void Render()
	{
		Console.WriteLine("[Load] - load game");
		Console.WriteLine("[Save] - save game");
		Console.WriteLine("[Help] - show help");
	}
	public ICommand GetCommand()
	{
		var command = Console.ReadLine();
		command = command.ToUpper();
		if (command == "LOAD")
		{
			return new SwitchStateCommand(_menager, new LoadState(_menager, this));
		}
		if (command == "SAVE")
		{
			return new SwitchStateCommand(_menager, new SaveState(_menager, this));
		}
		if (command == "HELP")
		{
			return new HelpCommand();
		}
		return new InvalidCommand();
	}
}
