using SilverZone.Domain.Users;

namespace SilverZone.Domain.Impl.Users
{
    public static class UserExtensions
    {
        public static User ToDomainEntity(this Data.User dataUser)
        {
            // assign default value
            User user = null;

            if (dataUser != null)
            {
                user = new User();
                user.Id = dataUser.Id;
                user.FirstName = dataUser.FirstName;
                user.LastName = dataUser.LastName;
                user.Username = dataUser.UserName;
                user.Email = dataUser.Email;
            }

            return user;
        }

        public static void UpdateFromDomainEntity(this Data.User dataUser, User user)
        {
            dataUser.Id = user.Id;
            dataUser.FirstName = user.FirstName;
            dataUser.LastName = user.LastName;
            dataUser.Email = user.Email;
            dataUser.UserName = user.Username;
        }
    }
}
