using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.cvičení
{
	class StringStatistics
	{

		string TextField;

		static char[] SplitSymbols = new char[] { ' ', '.', ',', ';', '?', '!', '\n' };


		//Constructor
		public StringStatistics(string Text)
		{
			this.TextField = Text;

		}


		// Metods

		//Word Counter
		public int WordCounter()
		{

			string[] Words = TextField.Split(SplitSymbols, StringSplitOptions.RemoveEmptyEntries);


			return Words.Length;
		}


		//Row Counter
		public int RowCounter()
		{
			string[] Text = TextField.Split(SplitSymbols, StringSplitOptions.RemoveEmptyEntries);

			var RowCounter = TextField.Split('\n').Length;

			return RowCounter;
		}


		//Sentence Counter
		public string[] SentenceCounter()
		{
			string TextSplit = TextField.Replace("\n", " ");
			string[] Sentence = Regex.Split(TextSplit, @"(\.|\?|\!)\s[A-Z]");

			return Sentence;

		}


		//Longest Word Counter
		public string LWCounter()
		{

			string[] Words = TextField.Split(SplitSymbols, StringSplitOptions.RemoveEmptyEntries);

			int maxLength = 0;
			string W = "";

			foreach (string s in Words)
			{

				if (s.Length > maxLength)
				{

					W = s;
					maxLength = s.Length;
				}

			}

			return W;
		}


		// Shortest Word Counter
		public string SWCounter()
		{

			string[] Words = TextField.Split(SplitSymbols, StringSplitOptions.RemoveEmptyEntries);

			int minLength = 10; //Well, i guess... I tried.
			string W = "";

			foreach (string s in Words)
			{

				if (s.Length < minLength) 
				{

					W = s;
					minLength = s.Length;
				}

			}

			return W;
		}


		//Most Often Words
		public string[] MostOftenWords()
		{
			//
			return null;
		}

		//Alphabet
		public string[] Alphabet()
		{

			string[] Alphabet = TextField.Split(SplitSymbols, StringSplitOptions.RemoveEmptyEntries);
			Array.Sort(Alphabet);
			Console.WriteLine(Alphabet);
			return null; //bohužel jsem nezjistil jak správně vypsat hodnoty...

		}

		//Covid
		public string[] CovidTest()
		{


			return null;
		}
	}












}
