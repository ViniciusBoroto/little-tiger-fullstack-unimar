using System;
using LittleTiger.DTOs;
using LittleTiger.Entities;
using LittleTiger.Interfaces;

namespace LittleTiger.UseCases
{
    public class CreateAchievementUseCase : IAchievementUseCase
    {
        private readonly IAchievementRepository _achievementRepository;

        public CreateAchievementUseCase(IAchievementRepository achievementRepository)
        {
            _achievementRepository = achievementRepository;
        }

        public Achievement Run(CreateAchievementRequest request)
        {
            // 1. Validação de Contrato (Input)
            if (request == null) throw new ArgumentNullException(nameof(request));

     

            // 3. Criação da Entidade
            // É importante que o construtor da sua classe Achievement valide as regras internas
            // (ex: pontos não podem ser negativos)
            var achievement = new Achievement(
                Guid.NewGuid(),
                request.Name,
                request.Description
            );

            // 4. Persistência
            _achievementRepository.Create(achievement);

            // 5. Retorno
            return achievement;
        }
    }
}