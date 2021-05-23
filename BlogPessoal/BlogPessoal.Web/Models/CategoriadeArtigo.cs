using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Models
{
    public class CategoriadeArtigo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [Display(Name = "Nome da Categoria")]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [DataType(DataType.MultilineText)]
        [StringLength(300, MinimumLength = 3)]
        public string Descricao { get; set; }
    }
}