using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.Entities;

namespace LittleTiger.DTOs.Request
{
    public class CheckForAchievementsRequest
    {
        public required Profile Profile { get; set; }
    }
}