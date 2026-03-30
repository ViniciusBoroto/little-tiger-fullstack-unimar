using LittleTiger.Entities;
using LittleTiger.Interfaces;

namespace LittleTiger.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public Player FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Player FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Player FindByNickname(string nick)
        {
            throw new NotImplementedException();
        }

        public void Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
