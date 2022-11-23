using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models.Services
{
    public class ServiceInputModel
    {
        [Required]
        [StringLength(
            40,
            ErrorMessage = "2 - 40 karakter arası olmalı.",
            MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(
            700,
            ErrorMessage = "50 - 700 karakter arası olmalı.",
            MinimumLength = 50)]
        public string Description { get; set; }
    }
}
