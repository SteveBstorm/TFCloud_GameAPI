using GameAPI.DTO.Form;
using GameAPI.Tools;
using GameAPI_BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_gameService.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody]GameFormDTO form)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _gameService.Create(form.Mapper());
            return Ok();
        }

        [HttpGet("byPlayer/{id}")]
        public IActionResult GetByPlayerId(int id)
        {
            return Ok(_gameService.GetByPlayerId(id));
        }

        [HttpGet("byGenre/{genre}")]
        public IActionResult GetByGenre(string genre)
        {
            return Ok(_gameService.GetByGenre(genre));
        }
    }
}
