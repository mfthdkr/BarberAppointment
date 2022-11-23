using System.ComponentModel.DataAnnotations;
using BusinessLayer.Models.Common.CustomValidationAttributes;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Models.Categories
{
    public class CategoryInputModel
    {
        [Required]
        [StringLength(
            40,
            ErrorMessage = "2 - 40 karakter arası olmalı.",
            MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(
            700,
            ErrorMessage = "50 - 700 karakter arası olmalı.",
            MinimumLength = 50)]
        public string Description { get; set; }

        [DataType(DataType.Upload)]
        [ValidateImageFile(ErrorMessage = "1MB' dan küçük olmalı.")]
        public IFormFile Image { get; set; }
    }
}
