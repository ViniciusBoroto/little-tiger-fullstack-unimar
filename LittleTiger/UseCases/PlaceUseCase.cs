using LittleTiger.DTOs.Request;
using LittleTiger.Entities;
using LittleTiger.Interfaces;
using LittleTiger.ValueObjects;
using System.Numerics;

namespace LittleTiger.UseCases
{
    public class PlaceUseCase
    {
        private readonly IBetRepository _betRepository;
        private readonly IPlayerRepository _playerRepository;
        public PlaceUseCase(IBetRepository betRepository, IPlayerRepository playerRepository)
        {
            _betRepository = betRepository;
            _playerRepository = playerRepository;
        }

        public void Run(PlaceRequest request)
        {
            Bet bet = _betRepository.FindById(request.BetId);
            this._validateBet(bet);
            Player player = _playerRepository.FindById(request.UserId);
            this._validatePlayer(player);

            player.Discount(new Amount(request.Amount));
            bet.Place(request.UserId, new Amount(request.Amount), new Team(request.Team));
             
            _betRepository.Update(bet);
            _playerRepository.Update(player);
        }

        private void _validatePlayer(Player player)
        {
            if (player == null)
            {
                throw new Exception("Player invalido");
            }
        }

        private void _validateBet(Bet bet)
        {
            if (bet == null)
            {
                throw new Exception("bet invalido");
            }
        }
    }
}
