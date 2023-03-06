using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadatakIgrica.Abstract;

namespace ZadatakIgrica.States
{
	class MainMenuState : IState
	{
		public ICommand GetCommand()
		{
			
		}

		public void Render()
		{
			Console.WriteLine("[New] - Create new game");
			Console.WriteLine("[Load] - load game");
			Console.WriteLine("[Save] - save game");
			Console.WriteLine("[Delete] - delete saved game");
			Console.WriteLine("[Help] - show help");
		}
	}
}
