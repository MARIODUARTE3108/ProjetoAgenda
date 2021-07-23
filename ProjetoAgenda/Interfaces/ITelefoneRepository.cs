using ProjetoAgenda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgenda.Interfaces
{
    public interface ITelefoneRepository
    {
        void Inserir(Telefone telefone);
        void Alterar(Telefone telefone);
        void Excluir(Telefone telefone);
        List<Telefone> Consultar();
        Telefone ObterPorId(Guid idTelefone);
        int ObterQuantidadeNumeros(Guid idContato);
    }
}
