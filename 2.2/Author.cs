namespace _2._2
{
	internal class Author
	{
		private string _name;
		private string _email;
		private char _gender = 'm';

		public Author(string name, string email, char gender)
		{
			_name = name;
			_email = email;
			_gender = gender;
		}
		public string GetName() { return _name; }
		public string GetEmail() { return _email; }
		public void SetEmail(string email) { _email = email; }
		public char GetGender() { return _gender; }
		public string Render()
		{
			return "Author[name = " + _name + ", email = " + _email + ", gender = " + _gender + "]";
		}
	}
}
