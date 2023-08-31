using System;
using SR;

namespace SR
{
	public class BookRepository
	{
        AppCont db = new AppCont();

        public void Select()
        {

        }

        public void Add(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public void Delete(Book book)
        {
            db.Books.Remove(book);
            db.SaveChanges();
        }
    }
}


