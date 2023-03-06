using System;
using System.Text;

class Program
{
	static void Main()
	{
		int dinari;

		Console.WriteLine("Unesite novac");
		dinari = Convert.ToInt32(Console.ReadLine());

		bool kupiPonovo = true;
		while (kupiPonovo == true)
		{
			Console.WriteLine("Cene proizvoda");
			Console.WriteLine("[1] Sok 50 dianra");
			Console.WriteLine("[2] Smoki 60 dianra");
			Console.WriteLine("[3] Cips 80 dianra");
			Console.WriteLine("[4] Cigare 350 dianra \n");

			int izabraniProizvod;
			if (!int.TryParse(Console.ReadLine(), out izabraniProizvod))
			{
				Console.WriteLine("Please enter a number");
			}

			izabraniProizvod = int.Parse(Console.ReadLine());
			bool JesiIzabraoProizvod = false;
			string imeIzabraniProizvod = "";
			int CenaIzabranaProizvoda = 0;

			if (izabraniProizvod == 1)
			{
				imeIzabraniProizvod = "Sok";
				CenaIzabranaProizvoda = 50;
				JesiIzabraoProizvod = true;
			}
			if (izabraniProizvod == 2)
			{
				imeIzabraniProizvod = "Smoki";
				CenaIzabranaProizvoda = 60;
				JesiIzabraoProizvod = true;
			}
			if (izabraniProizvod == 3)
			{
				imeIzabraniProizvod = "Cips";
				CenaIzabranaProizvoda = 80;
				JesiIzabraoProizvod = true;
			}
			if (izabraniProizvod == 4)
			{
				imeIzabraniProizvod = "Cigare";
				CenaIzabranaProizvoda = 350;
				JesiIzabraoProizvod = true;
			}

			if (!JesiIzabraoProizvod)
			{
				Console.WriteLine("Izabrao si nepostojece");
			}
			else
			{
				if (dinari < CenaIzabranaProizvoda)
				{
					Console.WriteLine("nemas dovoljno dinara, da li hocete da ubacite jos dinara? Da/Ne");

					string ubaciDinare = "";
					ubaciDinare = Console.ReadLine();
					ubaciDinare = ubaciDinare.ToUpper();
					int noviDinari;

					if (ubaciDinare == "DA")
					{
						Console.WriteLine("Koliko dinara hocete da ubacite? ");
						noviDinari = int.Parse(Console.ReadLine());
						dinari = dinari + noviDinari;
						Console.WriteLine("Novo stanje na racunu je: " + dinari);
					}
					else
					{
						kupiPonovo = false;
						Console.WriteLine("Hvala na kupovini");
					}
				}
				else
				{
					Console.WriteLine("Kupio si " + imeIzabraniProizvod + " Za " +
						CenaIzabranaProizvoda + " Dinara");

					dinari -= CenaIzabranaProizvoda;

					Console.WriteLine("imas jos " + dinari + " dinara");

					string odgovor = "";
					Console.WriteLine("Da li hoces da kupis jos nesto? (Da/Ne)");
					odgovor = Console.ReadLine();
					odgovor = odgovor.ToUpper();

					if (odgovor == "DA")
					{
						kupiPonovo = true;
					}
					else
					{
						kupiPonovo = false;
						Console.WriteLine("Hvala na kupovini");
					}
				}
			}
		}
		Console.ReadKey();
	}
}