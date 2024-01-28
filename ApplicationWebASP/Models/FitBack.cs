using System.ComponentModel.DataAnnotations;

namespace ApplicationWebASP.Models
{
    public class Fitback
    {
        [Display (Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

    }
}
