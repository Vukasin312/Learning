namespace _1._4
{
	internal class Employee
	{
		private int _id;
		private string _firstName;
		private string _lastName;
		private int _salary;

		public Employee(int id, string firstName, string lastName, int salary)
		{
			_id = id;
			_firstName = firstName;
			_lastName = lastName;
			_salary = salary;
		}
		public void ToString()
		{
			Console.WriteLine("Employee[id = {0}, name = {1} last name = {2}, salary = {3}]", _id, _firstName, _lastName, _salary);
		}
		public int GetID() { return _id; }
		public string GetFirstName() { return _firstName; }
		public string GetLastName() { return _lastName; }
		public int GetSalary() { return _salary; }
		public string GetName() { return _firstName + " " + _lastName; }
		public void SetSalary(int salary)
		{
			_salary = salary;
		}
		public int GetAnnualSalary()
		{
			return _salary * 12;
		}
		public int RaiseSalary(int percent)
		{
			percent = _salary / percent;
			_salary = _salary + percent;
			return _salary;
		}
	}
}
