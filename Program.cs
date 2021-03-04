using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.cvičení
{
	class Program
	{
		static void Main(string[] args)
		{
			string FillText =

				"Toto je retezec predstavovany nekolika radky, \n"
		+ "ktere jsou od sebe oddeleny znakem LF (Line Feed). \n"
		+ "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik? \n"
		+ "Toto je jen zkratka zkr. ale ne konec vety. A toto je \n"
		+ "posledni veta!";

			Console.WriteLine(FillText + "\n---------------------------------\n");

			StringStatistics UseMetod = new StringStatistics(FillText);

			Console.WriteLine("Numbers of Words: " + UseMetod.WordCounter());
			Console.WriteLine("Numbers of Lines: " + UseMetod.RowCounter());
			Console.WriteLine("Number of Sentences: " + UseMetod.SentenceCounter());


			Console.WriteLine("Longest Word: " + UseMetod.LWCounter());
			Console.WriteLine("Shortest Word: " + UseMetod.SWCounter());

			Console.WriteLine("Most often Words: " + UseMetod.MostOftenWords());
			Console.WriteLine("Words by Alphabet: " + UseMetod.Alphabet());
			Console.WriteLine("Covid Test: " + UseMetod.CovidTest());

			Console.ReadLine();
		}
	}
}
