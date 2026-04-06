using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleTiger.Entities
{
    public class User : EntityBase
    {
        public List<Achievement> Achievements { get; set; }
        public User()
        {
            Achievements = new List<Achievement>();
        }
        public void AddAchievement(Achievement achievement)
        {
            if (!Achievements.Any(a => a.Id == achievement.Id))
            {
                Achievements.Add(achievement);
            }
        }
    }
    
}