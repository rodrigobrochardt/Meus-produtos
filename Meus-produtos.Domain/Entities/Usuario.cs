using System.ComponentModel.DataAnnotations;

namespace Meus_produtos.Domain.Entities
{
    public class Usuario : Base
    {

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MaxLength(20, ErrorMessage = "Máximo de 20 caracteres")]
        [MinLength(3, ErrorMessage = "Minimo de 3 caracteres ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [MaxLength(20, ErrorMessage = "Máximo de 20 caracteres")]
        [MinLength(3, ErrorMessage = "Minimo de 3 caracteres ")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        [MaxLength(20, ErrorMessage = "Máximo de 20 caracteres")]
        [MinLength(8, ErrorMessage = "Minimo de 8 caracteres ")]
        public string Senha { get; set; }

        public Usuario() : base()
        {

        }
        public Usuario(dynamic obj) : base()
        {
            this.Id = obj.Id;
            this.Nome = obj.Nome;
            this.Email = obj.Email;
            this.Senha = obj.Senha;
        }
    }
}
