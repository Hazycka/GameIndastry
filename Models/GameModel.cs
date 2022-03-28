using System.ComponentModel.DataAnnotations;

namespace GameIndastry_v2.Models
{
    public class GameModel
    {
        public int Id { get; set; } = 1;
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MinLength(3), MaxLength(500)]
        public string Description { get; set; }
        public bool InSale { get; set; }
        public string GamePlayVideo { get; set; }
        //public int GenreId { get; set; } старый вариант связи 1к1
        public List<GamesGenres> Genres { get; set; } = new List<GamesGenres>();
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public string? Image { get; set; }
    }
}
