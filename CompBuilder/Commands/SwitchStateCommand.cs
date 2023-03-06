using CompBuilder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompBuilder.Commands
{
	class SwitchStateCommand : ICommand
	{
		private StateManager _configuration;
		private IState _state;

		public SwitchStateCommand(StateManager configuration, IState state)
		{
			_configuration= configuration;
			_state= state;
		}
		public void Execute()
		{
			_configuration.SwitchState(_state);
		}
	}
}
