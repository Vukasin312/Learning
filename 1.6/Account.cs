namespace _1._6
{
	internal class Account
	{
		private string _id;
		private string _name;
		private int _balance = 0;

		public Account(string id, string name)
		{
			_id = id;
			_name = name;
		}

		public Account(string id, string name, int balance)
		{
			_id = id;
			_name = name;
			_balance = balance;
		}
		public string GetId() { return _id; }
		public string GetName() { return _name; }
		public int GetBalance() { return _balance; }
		public int Credit(int amount)
		{
			return _balance = _balance + amount;
		}
		public int Debit(int amount)
		{
			if (amount <= _balance)
			{
				_balance = _balance - amount;
			}
			else
			{
				Console.WriteLine("Amount exceeded balance");
			}
			return _balance;
		}
		public int TransferTo(Account another, int amount)
		{
			if (amount <= _balance)
			{
				another.Credit(amount);
				_balance = _balance - amount;
			}
			else
			{
				Console.WriteLine("Amount exceeded balance");
			}
			return _balance;
		}
		public void ToString()
		{
			Console.WriteLine("Account[id: {0}, name: {1}, balance: {2}]", _id, _name, _balance);
		}
	}
}
