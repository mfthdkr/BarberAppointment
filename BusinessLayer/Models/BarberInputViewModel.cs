using CoreLayer.BusinessLayer.Models.CustomValidationAttributes;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Models
{
    public class BarberInputViewModel
    {
        [Required]
        [StringLength(
            40,
            ErrorMessage = "2 - 40 karakter arası olmalı.",
            MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        [StringLength(
            100,
            ErrorMessage = "5 - 100 karakter arası olmalı.",
            MinimumLength = 5)]
        public string Address { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = "1MB' dan küçük olmalı.")]
        public IFormFile Image { get; set; }
    }
}
