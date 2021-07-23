using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgenda.Entities
{
    public class Telefone
    {
        public Guid IdTelefone { get; set; }
        public string Numero { get; set; }

        public Guid IdContato { get; set; }
        public Contato Contato { get; set; }
    }
}
