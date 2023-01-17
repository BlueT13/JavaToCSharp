using System;

namespace Ex10
{
	internal class Book2
	{
		string title;
		string author;

		public Book2() : this("", "") { }

		public Book2(string title) : this(title, "unknown") { }

		public Book2(string title, string author)
		{
			this.title = title;
			this.author = author;
		}

		void Show()
		{
			Console.WriteLine(title + ": " + author);
		}

		public void BookNaming()
		{
			Book2 littlePrince = new Book2("Le Petit Prince", "Saint-Exupery");
			Book2 loveStory = new Book2("Chunhyang-jeon");
			Book2 emptyBook = new Book2();
			littlePrince.Show();
			loveStory.Show();
		}
	}
}
