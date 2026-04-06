using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleTiger.Interfaces
{
    public interface IUserRepository
    {
        void AddAchievementToUser(Guid userId, Guid achievementId);
    }
}