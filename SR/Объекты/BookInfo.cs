using System;
namespace SR
{
	public class BookInfo
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Genre { get; set; }

		public int BookId { get; set; }
		public Book Book { get; set; }
    }
}

