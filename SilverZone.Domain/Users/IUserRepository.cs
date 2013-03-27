using System;

namespace SilverZone.Domain.Users
{
   public interface IUserRepository
    {
       // create new user
       Result Save(User user);

       // get user by id
       User Get(Guid id);

       User Get(string username);

       Result Delete(User user);
       
    }
}
