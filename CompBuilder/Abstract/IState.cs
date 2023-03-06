namespace CompBuilder.Abstract
{
	interface IState
	{
		ICommand GetCommand();
		void Render();
	}
}
