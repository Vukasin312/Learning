namespace _2._4
{
	internal class Customer
	{
		private int _id;
		private string _name;
		private int _discount;

		public Customer(int id, string name, int discount)
		{
			_id = id;
			_name = name;
			_discount = discount;
		}
		public int GetId() { return _id; }
		public string GetName() { return _name; }
		public int GetDiscount() { return _discount; }
		public void SetDiscount(int discount) { _discount = discount; }
		public string Render()
		{
			return _name + "(" + _id + ")" + " (" + _discount + "%)";
		}
	}
}
