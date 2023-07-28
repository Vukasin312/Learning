namespace Computer_Store
{	

	public class Store
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public Store(string id, string name)
		{
			Id = id;
			Name = name;
		}		
	}
}
