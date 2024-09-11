using System.ComponentModel.DataAnnotations;

namespace GameAPI.DTO.Form
{
    public class SetGameDTO
    {
        [Required]
        public int PlayerId { get; set; }
        [Required]
        public int GameId { get; set; }
    }
}
