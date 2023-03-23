using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models
{
    public class CityViewModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(
            40,
            ErrorMessage = "2 - 40 karakter arası olmalı.",
            MinimumLength = 2)]
        public string Name { get; set; }

        public int BarbersCount { get; set; }
    }
}
