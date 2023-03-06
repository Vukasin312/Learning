using CompBuilder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompBuilder.Commands
{
	class InvalidCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Please enter a valid command");
		}
	}
}
