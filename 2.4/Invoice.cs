namespace _2._4
{
	internal class Invoice
	{
		private int _id;
		private Customer _customer;
		private double _amount;

		public Invoice(int id, Customer customer, double amount)
		{
			_id = id;
			_customer = customer;
			_amount = amount;
		}
		public int GetID() { return _id; }
		public Customer GetCustomer() { return _customer; }
		public void SetCustomer(Customer customer) { _customer = customer; }
		public double GetAmount() { return _amount; }
		public void SetAmount(double amount) { _amount = amount; }
		public int GetCustomerID()
		{
			Customer customer = _customer;
			return customer.GetId();
		}
		public string GetCustomerName()
		{
			Customer customer = _customer;
			return customer.GetName();
		}
		public int GetCustomerDiscount()
		{
			Customer customer = _customer;
			return customer.GetDiscount();
		}
		public double GetAmountAfterDiscount()
		{
			Customer customer = _customer;
			_amount = _amount - (_amount * customer.GetDiscount() / 100);
			return _amount;
		}
		public string Render()
		{
			return "Invoice[" + _id + ", customer= " + _customer.Render() + ",amount = " + _amount + "]";
		}
	}
}
