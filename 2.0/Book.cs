using System.Reflection.Metadata.Ecma335;

namespace _2._0
{
	internal class Book
	{
		private string _name;
		private Author _author;
		private double _price;
		private int _qty = 0;

		public Book(string name, Author author, double price)
		{
			_name = name;
			_author = author;
			_price = price;
		}

		public Book(string name, Author author, double price, int qty)
		{
			_name = name;
			_author = author;
			_price = price;
			_qty = qty;
		}
		public string GetName() { return _name; }
		public Author GetAuthor() { return _author; }
		public double GetPrice() { return _price; }
		public void SetPrice(double price) { _price = price; }
		public int GetQty() { return _qty; }
		public void SetQty(int qty) { _qty = qty; }
		public string GetAuthorName() { return _author.GetName(); }
		public string GetAuthorEmail() { return _author.GetEmail(); }
		public string Render()
		{
			return "Book[name= " + _name + ", author = " + _author.Render() + ", price = " + _price + ", qty = " + _qty + "]";
		}
	}
}
