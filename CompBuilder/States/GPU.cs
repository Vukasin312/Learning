using CompBuilder.Abstract;
using CompBuilder.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompBuilder.States
{
    class GPU : IState
    {
        private StateManager _manager;
        private IState _lastState;
        public GPU(StateManager manager, IState lastState)
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
			Console.WriteLine("Your graphics card is Nvidia 1660 TI");
            Console.WriteLine("[Back] - go back to configuration");
        }
    }
}
