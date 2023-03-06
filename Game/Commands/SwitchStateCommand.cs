using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SwitchStateCommand : ICommand
{
	private StateManager _menager;
	private IState _newState;
	public SwitchStateCommand(StateManager menager, IState newState)
	{
		_menager = menager;
		_newState = newState;
	}
	public void Execute()
	{
		_menager.SwitchState(_newState);
	}
}
