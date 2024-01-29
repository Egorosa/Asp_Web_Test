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
        [Display (Name = "Оставьте сообщение")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        [StringLength (30, ErrorMessage = "Текст не менее 30 символов")]
        public string Message { get; set; }
    }
}
