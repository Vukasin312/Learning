using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StateManager
{
	private IState _state;

	public void SwitchState(IState state)
	{
		_state = state;
	}

	public void Run(IState initialState)
	{
		_state = initialState;

		while (true)
		{
			_state.Render();
			var command = _state.GetCommand();
			command.Execute();
		}
	}
}
