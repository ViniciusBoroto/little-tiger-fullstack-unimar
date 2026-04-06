using LittleTiger.Interfaces;
using LittleTiger.Entities;

namespace LittleTiger.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {
        private static List<Achievement> _achievement = new List<Achievement>();

        public List<Achievement> GetAll()
        {
            return _achievement;
        }

        public void Create(Achievement conquest)
        {
            if (conquest == null)
            {
                throw new Exception("Nao foi possivel adicionar a conquista");
            }
            _achievement.Add(conquest);
            return "deu certo";
        }
    }
}
