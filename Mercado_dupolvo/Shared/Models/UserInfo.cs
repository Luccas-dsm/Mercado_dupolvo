using System.ComponentModel.DataAnnotations;

namespace Mercado_dupolvo.Shared.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage = "Informe o email")]
        [EmailAddress(ErrorMessage = "Formato do email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a password")]
        public string Password { get; set; }
    }
}
