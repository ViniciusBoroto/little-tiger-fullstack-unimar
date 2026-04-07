using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleTiger.Interfaces
{
    public interface IAddAchievementToUserUseCase
    {
        void Run(Guid userId, Guid achievementId);
    }
}
