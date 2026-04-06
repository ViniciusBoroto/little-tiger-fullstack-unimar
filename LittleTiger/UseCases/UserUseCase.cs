using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.Interfaces;

namespace LittleTiger.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserRepository _userRepository;

        public UserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddAchievementToUser(Guid userId, Guid achievementId)
        {
            if (userId == Guid.Empty)
            {
                throw new Exception("UserId cannot be empty");
            }

            if (achievementId == Guid.Empty)
            {
                throw new Exception("AchievementId cannot be empty");
            }

            _userRepository.AddAchievementToUser(userId, achievementId);
        }
    }
}
