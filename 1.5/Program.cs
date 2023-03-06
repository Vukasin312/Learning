namespace _1._5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var invoiceItem = new InvoiceItem("A101", "Pen", 888, 0.08);
			invoiceItem.ToString();

			invoiceItem.SetQuality(999);
			invoiceItem.SetUnitPrice(0.99);
			invoiceItem.ToString();
			Console.WriteLine("id is: {0}", invoiceItem.GetID());
			Console.WriteLine("description is: {0}", invoiceItem.GetDescription());
			Console.WriteLine("qulity is: {0}", invoiceItem.GetQuality());
			Console.WriteLine("unit price is: {0}", invoiceItem.GetUnitPrice());

			Console.WriteLine("total is: {0}", invoiceItem.GetTotal());


			Console.ReadKey();
		}
	}
}