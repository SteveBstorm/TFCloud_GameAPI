using System.ComponentModel.DataAnnotations;

namespace GameAPI.DTO.Form
{
    public class GameFormDTO
    {
        [Required]
        public string Title { get; set; }
        [Range(1970, 2035)]
        public int ReleaseYear { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Editor { get; set; }
    }
}
