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

            return aaaaa;
        }

        public Achievement GetById(Guid id)
        {
            var achievement = _achievements.FirstOrDefault(a => a.Id == id);
            if (achievement == null)
                throw new KeyNotFoundException($"Achievement with ID {id} not found.");
            return achievement;
        }
    }
}