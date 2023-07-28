using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{
	public class Storage
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Adress { get; set; }
		public int WorkingHours { get; set; }
		public Storage(string id, string name, string adress, int workingHours)
		{
			Id = id;
			Name = name;
			Adress = adress;
			WorkingHours = workingHours;
		}
	}
}
