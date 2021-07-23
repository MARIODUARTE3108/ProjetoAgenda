using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgenda.Models
{
    public class TelefoneCadastroModel
    {
        [MinLength(9, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(11, ErrorMessage = "Por favor, informe no máximo  {1}caracteres.")]
        [Required(ErrorMessage = "Por favor, informe um múmero de telefone.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id do contato.")]
        public Guid IdContato { get; set; }
    }
}
