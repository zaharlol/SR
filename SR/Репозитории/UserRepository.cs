using System;
namespace SR
{
	public class UserRepository
	{
		AppCont db = new AppCont();

		public void Select()
		{
			db.Users.ToList();
		}

		public void Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

		public void Delete(User user)
		{
			db.Users.Remove(user);
            db.SaveChanges();
        }
	}
}

