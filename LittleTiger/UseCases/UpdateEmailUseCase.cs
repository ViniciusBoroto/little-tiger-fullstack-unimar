using LittleTiger.Entities;
using LittleTiger.Interfaces;
using LittleTiger.ValueObjects;

namespace LittleTiger.UseCases
{
    public class UpdateEmailUseCase
    {
        private readonly IPlayerRepository _playerRepository;
        public UpdateEmailUseCase(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public void Run(Guid id, string newEmail)
        {
            if (id == Guid.Empty)
            {
                throw new Exception("Id Invalido");
            }

            Player player = _playerRepository.FindById(id);

            if (player == null)
            {
                throw new Exception("jogador invalido");
            }

            Player playerWithEmail = _playerRepository.FindByEmail(newEmail);

            if (playerWithEmail != null)
            {
                throw new Exception("Email ja cadastrado");
            }

            player.UpdateEmail(new Email(newEmail));
            _playerRepository.Update(player);
        }
    }
}
