using LittleTiger.Entities;
using LittleTiger.Interfaces;
using LittleTiger.ValueObjects;

namespace LittleTiger.UseCases
{
    public class UpdateNicknameUseCase
    {
        private readonly IPlayerRepository _playerRepository;

        public UpdateNicknameUseCase(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public void Run(Guid id, string newNickname)
        {
            try
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

                Player playerWithNick = _playerRepository.FindByNickname(newNickname);

                if (playerWithNick == null)
                {
                    throw new Exception("Nickname ja em uso");
                }

                player.UpdateNickname(new Nickname(newNickname));
                _playerRepository.Update(player);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
