using ss04.Models;

namespace ss04.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        User FindUser(string username);

    }
}
