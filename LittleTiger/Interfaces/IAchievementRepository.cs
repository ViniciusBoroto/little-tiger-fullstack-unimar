using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.Entities;

using System;
using LittleTiger.Entities;

namespace LittleTiger.Interfaces
{
    public interface IAchievementRepository
    {
        // List<Achievement> GetAll();
<<<<<<< HEAD
        Achievement GetById(Guid id);
        Achievement Create(string name, string description);
=======
        Achievement Create(Achievement aaaaa);
>>>>>>> 757a5b8fe03ae8face3e24f676e73ec6eeee581c
        Achievement GetById(Guid id);
    }
}