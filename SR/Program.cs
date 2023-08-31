namespace SR
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            BookRepository bookRepository = new BookRepository();

            using (var db = new AppCont())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var user1 = new User { Name = "Захар", Email = "ZXC@mail.ru" };
                var user2 = new User { Name = "Назар", Email = "CXZ@mail.ru" };

                var book1 = new Book { Name = "Война", Year = 2015};
                var book2 = new Book { Name = "July", Year = 2020};
                var book3 = new Book { Name = "FireFire", Year = 2010 };

                var bookInfo1 = new BookInfo { Name = "Энгельс", Genre = "Военный"};
                var bookInfo2 = new BookInfo { Name = "Thomas", Genre = "Роман" };
                var bookInfo3 = new BookInfo { Name = "Andrey", Genre = "Драма" };

                db.Users.AddRange(user1, user2);
                db.Books.AddRange(book1, book2, book3);
                db.BooksInfo.AddRange(bookInfo1, bookInfo2, bookInfo3);

                book1.User = user2;
                book2.User = user1;
                book3.User = user1;

                book1.BookInfo = bookInfo2;
                book2.BookInfo = bookInfo3;
                book3.BookInfo = bookInfo1;

                db.SaveChanges();
            }
        }
    }
}