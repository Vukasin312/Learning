﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	class InvalidCommand : ICommand
	{
		public void Execute()
		{
			Console.WriteLine("Invalid Command!");
		}
	}


