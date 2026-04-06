using System;
using System.Collections.Generic;
using System.Linq;
using LittleTiger.Entities;
using LittleTiger.Interfaces;

namespace LittleTiger.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();

        public User GetById(Guid userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public void Update(User user)
        {
            var index = _users.FindIndex(u => u.Id == user.Id);

            if (index == -1)
                throw new KeyNotFoundException($"User with ID {user.Id} not found.");

            _users[index] = user;
        }
    }
}