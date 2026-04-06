using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleTiger.Entities
{
    public class User : EntityBase
    {
        public List<Achievement> Achievements { get; set; }
    }
}