using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgenda.Models
{
    public class ContatoEdicaoModel
    {
        public Guid IdContato { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do contato.")]
        public string Nome { get; set; }
    }
}
