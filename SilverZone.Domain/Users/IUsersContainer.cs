namespace SilverZone.Domain.Users
{
    public interface IUsersContainer
    {
        IUserRepository Repository { get; } 
    }
}