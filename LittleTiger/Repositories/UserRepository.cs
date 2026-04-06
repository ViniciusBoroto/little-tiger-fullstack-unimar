using LittleTiger.Contexts.Auth.Entities;
using LittleTiger.Contexts.Auth.Repositories;
using LittleTiger.Entities;

namespace LittleTiger.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users = new List<User> ();

        public void AddAchievementToUser(User user, Achievement achieveme)
        {
            if (achieveme == null)
            {
                throw new Exception("vix deu erro man...");
            }
            _users.Add(user);


        }
    }
}
