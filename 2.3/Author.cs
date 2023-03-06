namespace _2._3
{
	internal class Author
	{
		private string _name;
		private string _email;

		public Author(string name, string email)
		{
			_name = name;
			_email = email;
		}
		public string GetName() { return _name; }
		public string GetEmail() { return _email; }
		public void SetEmail(string email) { _email = email; }
		public string Render()
		{
			return "[name = "+ _name + ", email = "+ _email + "]";
		}
	}
}
