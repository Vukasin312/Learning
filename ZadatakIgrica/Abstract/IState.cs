namespace ZadatakIgrica.Abstract
{
	interface IState
	{
		ICommand GetCommand();
		void Render();
	}
}
