using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Chat.ViewModels
{
    public class IndexModel
    {
        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пустоесообщение")]
        public string Message { get; set; }
    }
}
