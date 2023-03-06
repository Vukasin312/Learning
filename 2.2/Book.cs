namespace _2._2
{
	internal class Book
	{
		private string _name;
		private Author[] _authors;
		private double _price;
		private int _qty = 0;

		public Book(string name, Author[] authors, double price)
		{
			_name = name;
			_authors = authors;
			_price = price;
		}

		public Book(string name, Author[] authors, double price, int qty)
		{
			_name = name;
			_authors = authors;
			_price = price;
			_qty = qty;
		}
		public string GetName() { return _name; }
		public Author[] GetAuthors() { return _authors; }
		public double GetPrice() { return _price; }
		public void SetPrice(double price) { _price = price; }
		public int GetQty() { return _qty; }
		public void SetQty(int qty) { _qty = qty; }
		public string GetAuthorName()
		{
			string result = "";
			for (int i = 0; i < _authors.Length; i++)
			{
				result += _authors[i].GetName()+",";		
			}			
			return result;
		}
		public string Render()
		{
			// dodaj da radi sa svi autori
			// bilo sta
			// da izazovemo konflikts
			return "Book[name = " + _name + _authors[0].Render() + _authors[1].Render() + "price = " + _price + "qty = " + _qty + "]";
		}
	}
}
