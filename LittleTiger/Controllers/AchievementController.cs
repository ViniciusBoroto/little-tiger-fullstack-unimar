using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.DTOs;
using LittleTiger.Entities;
using LittleTiger.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LittleTiger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AchievementController : ControllerBase
    {
        private readonly IAchievementUseCase _achievementUC;

        public AchievementController(IAchievementUseCase achievementUC)
        {
            _achievementUC = achievementUC;
        }

        [HttpPost("")]
        public IActionResult CheckForAchievements([FromBody] CreateAchievementRequest request)
        {
            try
            {
                _achievementUC.Run(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }   
    }
}