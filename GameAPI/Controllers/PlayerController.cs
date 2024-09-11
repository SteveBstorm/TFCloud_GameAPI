using GameAPI.DTO.Form;
using GameAPI.Tools;
using GameAPI_BLL.Interface;
using GameAPI_BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace GameAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;

            //Liste = new List<Player>();
            //Liste.Add(new Player
            //{
            //    Id = 1,
            //    Nickname = "Elean",
            //    Email = "steve.lorent@bstorm.be"
            //});
        }


        /// <summary>
        /// Permet de récupérer la liste des joueurs
        /// </summary>
        /// <returns>IEnumerable</returns>
        /// <params></params>
        [HttpGet]
        public IActionResult Get()
        {
            //return StatusCode(200, "Arthur");
            //return NotFound();
            //return Ok(FakePlayerService.Liste);
            return Ok(_playerService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Player p = FakePlayerService.Liste.FirstOrDefault(p => p.Id == id);
            //if (p is null)
            //    return NotFound("Joueur introuvable");
            //return Ok(p);
            try
            {
                return Ok(_playerService.GetById(id));

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(PlayerFormDTO player)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (_playerService.Create(player.Mapper()))
            {
                return Ok("joueur créé avec succès");
            }
            return BadRequest("Une erreur s'est produite");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Player playerToDelete = FakePlayerService.Liste.FirstOrDefault(x => x.Id == id);

            //if (playerToDelete is null)
            //    return NotFound("Joueur non trouvé");

            //FakePlayerService.Liste.Remove(playerToDelete);

            _playerService.Delete(id);
            return Ok("Suppression OK");
        }


        //Identifier la provenance de l'info
        //Header => Info sur l'envoyeur ET sur le contenu de la requête
        //Body => Contenu de la requête (Objet / Fichier / autre)
        //Route => Info contenue dans l'url 
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] PlayerFormDTO player)
        {

            if (!ModelState.IsValid) return BadRequest();

            Player p = player.Mapper();
            p.Id = id;

            _playerService.Update(p);

            return Ok();

            //try
            //{
            //    FakePlayerService.Liste.First(x => x.Id == id).Email = player.Email;
            //    FakePlayerService.Liste.First(x => x.Id == id).Nickname = player.Nickname;
            //    return Ok("Update effectué");
            //}
            //catch (Exception ex)
            //{
            //    return BadRequest("Joueur inéxistant");
            //}
        }
    }
}
