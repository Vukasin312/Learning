using MongoDB.Bson.Serialization.Attributes;

namespace Computer_Store
{
	public class Article
	{		
		public string Id { get; set; }
		public string Name { get; set; }
		public int Barcode { get; set; }
		public string Type { get; set; }
		public int Price { get; set; }
		public int Discount { get; set; }
		private int _priceWithDiscount;
		public int PriceWithDiscount
		{
			get { return _priceWithDiscount; }
			set { _priceWithDiscount = (Price * Discount) / 100;
				_priceWithDiscount = Price - PriceWithDiscount;
			}
		}
		public Article(string id, string name, int barcode, string type, int price, int discount)
		{
			Id = id;
			Name = name;
			Barcode = barcode;
			Type = type;
			Price = price;
			Discount = discount;
		}
		//public int GetID() {  return _id; }
		//public string GetName() { return _name; }
		//public int GetBarCode() { return _barcode;}
		//public string GetType() { return _type;}
		//public int GetPrice() { return _price;}
		//public int GetDiscount() { return _discount;}


	}
}
