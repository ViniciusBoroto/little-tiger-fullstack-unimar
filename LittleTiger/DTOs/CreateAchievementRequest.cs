using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleTiger.DTOs
{
    public class CreateAchievementRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}