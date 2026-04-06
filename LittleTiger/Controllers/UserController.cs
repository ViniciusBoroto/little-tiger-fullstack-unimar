using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.DTOs;
using LittleTiger.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LittleTiger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserUseCase _userUC;

        public UserController(IUserUseCase userUC)
        {
            _userUC = userUC;
        }

        [HttpPost("add-achievement")]
        public IActionResult AddAchievementToUser([FromBody] AddAchievementToUserRequest request)
        {
            try
            {
                _userUC.AddAchievementToUser(request.UserId, request.AchievementId);
                return Ok("Achievement added to user successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
