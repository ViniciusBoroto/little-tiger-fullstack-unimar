using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.Contexts.Auth.Entities;
using LittleTiger.Interfaces;

namespace LittleTiger.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserRepository _userRepository;
        private readonly IAchievementRepository _achievementRepository;

        public UserUseCase(IUserRepository userRepository, IAchievementRepository achievementRepository)
        {
            _userRepository = userRepository;
            _achievementRepository = achievementRepository;
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
            var achievement =_achievementRepository.GetById(achievementId);
            var user = _userRepository.GetById(userId);

            user.AddAchievement(achievement);

            _userRepository.Update(user);
           
        }
    }
}
