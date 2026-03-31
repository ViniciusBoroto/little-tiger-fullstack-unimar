using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LittleTiger.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LittleTiger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AchievementController : ControllerBase
    {
     [HttpPost("Place")]
        public IActionResult CheckForAchievements(Profile profile)
        {
            try
            {
                _placeUseCase.Run(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }   
    }
}