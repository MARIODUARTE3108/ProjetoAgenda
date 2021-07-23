using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgenda.Entities
{
    public class Contato
    {
        public Guid IdContato { get; set; }
        public string Nome { get; set; }
        
        public List<Telefone> Telefones { get; set; }
    }
}
