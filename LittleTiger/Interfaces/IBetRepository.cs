using LittleTiger.Entities;

namespace LittleTiger.Interfaces
{
    public interface IBetRepository
    {
        public Bet FindById(Guid id);
        public void Update(Bet player);
    }
}
