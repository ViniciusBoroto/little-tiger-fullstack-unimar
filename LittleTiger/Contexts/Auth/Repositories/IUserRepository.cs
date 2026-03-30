using LittleTiger.Contexts.Auth.Entities;

namespace LittleTiger.Contexts.Auth.Repositories
{
    public interface IUserRepository
    {
        public User Auth(string email, string password);
    }
}
