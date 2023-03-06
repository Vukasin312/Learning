namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			var menager = new StateManager();
			menager.Run(new MainMenuState(menager));

			Console.ReadKey();
		}
		
	}
}