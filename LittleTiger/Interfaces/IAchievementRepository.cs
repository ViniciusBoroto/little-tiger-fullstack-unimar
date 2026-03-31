using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.Entities;

namespace LittleTiger.Interfaces
{
    public interface IAchievementRepository
    {
        List<Achievement> GetAll();
    }
}