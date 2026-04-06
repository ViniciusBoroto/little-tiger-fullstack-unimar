using System;
using System.Collections.Generic;
using System.Linq;
using LittleTiger.Entities;
using LittleTiger.Interfaces;

namespace LittleTiger.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {
        private readonly List<Achievement> _achievements = new();

        public Achievement Create(Achievement aaaaa)
        {
           
            _achievements.Add(aaaaa);

            return achievement;
        }

        public Achievement GetById(Guid id)
        {
            return _achievements.FirstOrDefault(a => a.Id == id);
        }
    }
}