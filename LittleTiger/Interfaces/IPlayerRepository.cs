using LittleTiger.Entities;

namespace LittleTiger.Interfaces
{
    public interface IPlayerRepository
    {
        public Player FindById(Guid id);
        public Player FindByEmail(string email);
        public Player FindByNickname(string nick);

        public void Update(Player player);
    }
}
