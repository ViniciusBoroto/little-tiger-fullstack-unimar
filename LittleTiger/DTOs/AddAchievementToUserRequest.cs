using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleTiger.DTOs
{
    public class AddAchievementToUserRequest
    {
        public Guid UserId { get; set; }
        public Guid AchievementId { get; set; }
    }
}
