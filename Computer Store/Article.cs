using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{
	internal class Article
	{
		private int _id { get; set; }
		private string _name { get; set; }
		private int _barcode { get; set; }
		private string _type { get; set; }
		private int _price { get; set; }
		private int _discount { get; set; }

		public Article(int id, string name, int barcode, string type, int price, int discount)
		{
			_id = id;
			_name = name;
			_barcode = barcode;
			_type = type;
			_price = price;
			_discount = discount;
		}
		public int GetID() {  return _id; }
		public string GetName() { return _name; }
		public int GetBarCode() { return _barcode;}
		public string GetType() { return _type;}
		public int GetPrice() { return _price;}
		public int GetDiscount() { return _discount;}
		

	}
}
