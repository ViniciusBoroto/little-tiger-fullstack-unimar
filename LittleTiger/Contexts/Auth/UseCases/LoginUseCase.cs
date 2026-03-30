using LittleTiger.Contexts.Auth.Entities;
using LittleTiger.Contexts.Auth.Repositories;

namespace LittleTiger.Contexts.Auth.UseCases
{
    public class LoginUseCase
    {
        private readonly IUserRepository _userRepository;
        public LoginUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public string Run(string email, string password)
        {
            User user = _userRepository.Auth(email, password);
            if (user == null)
            {
                throw new Exception("Usuario nao encontrado");
            }

            return user.Login();
        }
    }
}
