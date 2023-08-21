using System.ComponentModel.DataAnnotations;

namespace MeuDesafio.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string NomeCompleto { get; set; }

        [Required]
        [MaxLength(14)] // Tamanho máximo de CPF ou CNPJ
        public string CpfCnpj { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public decimal Saldo { get; set; }
    }
}
