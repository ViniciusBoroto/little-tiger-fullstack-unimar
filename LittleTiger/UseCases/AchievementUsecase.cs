using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.DTOs.Request;
using LittleTiger.Entities;



namespace LittleTiger.UseCases
{
    public class AchievementUsecase
    {
        public List<Achievement> Run(CheckForAchievementsRequest request)
        {
            var profile = request.Profile;   
        }
    }
}