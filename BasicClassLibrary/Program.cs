using System.IO;

namespace BasicClassLibrary
{
	class Program
	{
		static void Main(string[] args)
		{
			var directoryInfo = new DirectoryInfo("c:\\");
			foreach (FileInfo info in directoryInfo.GetFiles())
			{
				Console.WriteLine("{0} - {1}", info.Name, info.Length);
			}

			foreach (DirectoryInfo info in directoryInfo.GetDirectories())
			{
				Console.WriteLine("{0}", info.Name);
			}

			Console.ReadKey();
		}
	}
}