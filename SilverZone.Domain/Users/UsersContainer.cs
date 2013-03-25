namespace SilverZone.Domain.Users
{
    public class UsersContainer: IUsersContainer
    {
        public IUserRepository Repository { get; private set; }

        public UsersContainer(IUserRepository repository)
        {
            Repository = repository;
        }

    }
}