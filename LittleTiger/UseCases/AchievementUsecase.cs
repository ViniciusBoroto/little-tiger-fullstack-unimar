using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.DTOs.Request;
using LittleTiger.Entities;
using LittleTiger.Interfaces;



namespace LittleTiger.UseCases
{
    public class AchievementUsecase
    {
        private readonly IAchievementRepository _achievementsRepository;
        public AchievementUsecase(IAchievementRepository _achievementsRepository)
        {
            this._achievementsRepository = _achievementsRepository;
        }
        public List<Achievement> Run(CheckForAchievementsRequest request)
        {
            var achievements = _achievementsRepository.GetAll();
            var unlockedAchievements = new List<Achievement>();
            foreach (var achievement in achievements)
            {
                if (achievement.ProfileHasAchievement(request.Profile))
                {
                    unlockedAchievements.Add(achievement);
                }
            }
            return unlockedAchievements;
        }
    }
}