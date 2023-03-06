namespace _1._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var employee = new Employee(8, "Vukasin", "Simic", 80000);
			employee.ToString();
			employee.SetSalary(999);
			employee.ToString();
			Console.WriteLine("firstname is: " + employee.GetFirstName());
			Console.WriteLine("lastname is: " + employee.GetLastName());
			Console.WriteLine("salary is: " + employee.GetSalary());

			Console.WriteLine("name is: " + employee.GetName());
			Console.WriteLine("annual salary is: " + employee.GetAnnualSalary());

			Console.WriteLine(employee.RaiseSalary(10));
			employee.ToString();


			Console.ReadKey();
		}
	}
}