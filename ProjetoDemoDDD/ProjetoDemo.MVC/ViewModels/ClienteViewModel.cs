using ProjetoDemo.Data.EntityConfig;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDemo.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome!")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome!")]
        [MaxLength(150, ErrorMessage = "Maximo {0} caracteres!")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres!")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail!")]
        [MaxLength(100, ErrorMessage = "Maximo {0} caracteres!")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }



        public virtual System.Collections.Generic.IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}