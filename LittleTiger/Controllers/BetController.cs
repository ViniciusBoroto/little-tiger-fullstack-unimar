using LittleTiger.DTOs.Request;
using LittleTiger.Interfaces;
using LittleTiger.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace LittleTiger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BetController : ControllerBase
    {
        private readonly PlaceUseCase _placeUseCase;
        public BetController(PlaceUseCase placeUseCase) 
        {
            _placeUseCase = placeUseCase;
        }

        [HttpPost("Place")]
        public IActionResult Place([FromBody] PlaceRequest request)
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
