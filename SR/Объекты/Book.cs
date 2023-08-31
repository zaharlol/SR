using System;
namespace SR
{
	public class Book
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Year { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public BookInfo BookInfo { get; set; }
    }
}

