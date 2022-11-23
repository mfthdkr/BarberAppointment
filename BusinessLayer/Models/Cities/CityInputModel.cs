using System.ComponentModel.DataAnnotations;


namespace BusinessLayer.Models.Cities
{
    public class CityInputModel
    {
        [Required]
        [StringLength(
            40,
            ErrorMessage = "2 - 40 karakter arası olmalı.",
            MinimumLength = 2)]
        public string Name { get; set; }
    }
}
