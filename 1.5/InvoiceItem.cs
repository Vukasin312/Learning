namespace _1._5
{
	internal class InvoiceItem
	{
		private string _id;
		private string _description;
		private int _quality;
		public double _unitPrice;

		public InvoiceItem(string id, string description, int quality, double unitPrice)
		{
			_id = id;
			_description = description;
			_quality = quality;
			_unitPrice = unitPrice;
		}
		public void ToString()
		{
			Console.WriteLine("InvoicItem[id = {0}, description = {1}, quality = {2}, unit price = {3}]", _id, _description, _quality, _unitPrice);
		}
		public string GetID() { return _id; }
		public string GetDescription() { return _description; }
		public int GetQuality() { return _quality; }
		public void SetQuality(int quality)
		{
			_quality = quality;
		}
		public double GetUnitPrice() { return _unitPrice; }
		public void SetUnitPrice(double unitPrice)
		{
			_unitPrice = unitPrice;
		}
		public double GetTotal()
		{
			return _unitPrice * _quality;
		}
	}
}
