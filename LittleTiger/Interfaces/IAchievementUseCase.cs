using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.DTOs;
using LittleTiger.Entities;

namespace LittleTiger.Interfaces
{
    public interface IAchievementUseCase
    {
        Achievement Run(CreateAchievementRequest request);
    }
}