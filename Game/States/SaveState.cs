class SaveState : IState
{
	private StateManager _menager;
	private IState _lastState;

	public SaveState(StateManager menager, IState lastState)
	{
		_menager = menager;
		_lastState = lastState;
	}
	public void Render()
	{
		Console.WriteLine("---------------");
		Console.WriteLine("Save State ----");
		Console.WriteLine("[Back]---------");
		Console.WriteLine("---------------");
	}
	public ICommand GetCommand()
	{
		var input = Console.ReadLine();
		input = input.ToUpper();
		if (input == "BACK")
		{
			return new SwitchStateCommand(_menager, _lastState);
		}
		return new InvalidCommand();
	}
}

