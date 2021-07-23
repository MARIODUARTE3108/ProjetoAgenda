using ProjetoAgenda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgenda.Interfaces
{
    public interface IContatoRepository
    {
        void Inserir(Contato contato);
        void Alterar(Contato contato);
        void Excluir(Contato contato);
        List<Contato> Consultar();
        Contato ObterPorId(Guid idContato);
    }
}
