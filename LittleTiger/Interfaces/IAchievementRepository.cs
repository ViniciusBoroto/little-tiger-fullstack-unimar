using System;
using LittleTiger.Entities;

namespace LittleTiger.Interfaces
{
    public interface IAchievementRepository
    {
        Achievement Create(Achievement aaaaa);
        Achievement GetById(Guid id);
    }
}