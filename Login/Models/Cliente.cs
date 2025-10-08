using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Login.Models
{
    public class Cliente
    {
        [Display(Name = "Código", Description = "Código do cliente")]
        public int Id { get; set; }


        [Display(Name = "Nome", Description = "Nome Completo do Cliente")]
        public string Nome { get; set; }


        [Display(Name = "DataNascimento", Description = "Data de Nascimento do Cliente")]
        public DateOnly DataNascimento { get; set; }

        [Display(Name = "Sexo", Description = "Sexo do Cliente")]
        public string Sexo { get; set; }

        [Display(Name = "CPF", Description = "CPF Do Cliente")]
        public BigInteger CPF { get; set; }

        [Display(Name = "CEP", Description = "CEP Do Cliente")]
        public int CEP { get; set; }

        [Display(Name = "Email", Description = "Email do Cliente")]
        public string Email { get; set; }

        [Display(Name = "Telefone", Description = "Telefone do Cliente")]
        public BigInteger Telefone { get; set; }

        [Display(Name = "Senha", Description = "Senha do Cliente")]
        public string Senha { get; set; }

        [Display(Name = "Situação", Description = "Situação do Cliente")]
        public string Situacao { get; set; }
    }
}
