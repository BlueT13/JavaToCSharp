using System;

namespace Ex10
{
	internal class Book
	{
		string title;
		string author;

		public Book() { }

		public Book(string t)
		{
			title = t; author = "unknown";
		}

		public Book(string t, string a)
		{
			title = t; author = a;
		}

		public void PrintBook()
		{
			Book littlePrince = new Book("Le Petit Prince", "Saint-Exupery");
			Book loveStory = new Book("Chunhyang-jeon");
			Console.WriteLine(littlePrince.title + ": " + littlePrince.author);
			Console.WriteLine(loveStory.title + ": " + loveStory.author);
		}
	}
}
