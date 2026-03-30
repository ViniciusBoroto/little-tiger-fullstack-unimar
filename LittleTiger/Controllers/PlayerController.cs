using LittleTiger.DTOs.Request;
using LittleTiger.Interfaces;
using LittleTiger.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace LittleTiger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        public PlayerController() 
        {
            
        }

        [HttpPut("UpdateNickname")]
        public IActionResult UpdateNickname([FromBody] UpdateNicknameRequest request)
        {
            try
            {
                var useCase = new UpdateNicknameUseCase();
                useCase.Run(request.Id, request.Nickname);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateEmail")]
        public IActionResult UpdateEmail(UpdateEmailRequest request)
        {
            try
            {
                var useCase = new UpdateEmailUseCase();
                useCase.Run();
                return Ok();
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }
        }
    }
}
