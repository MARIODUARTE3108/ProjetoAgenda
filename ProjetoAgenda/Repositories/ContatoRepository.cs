using Dapper;
using ProjetoAgenda.Entities;
using ProjetoAgenda.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAgenda.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly string _connectionstring;

        public ContatoRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void Inserir(Contato contato)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_INSERIRCONTATO",
                new
                {
                    @NOME = contato.Nome
                   
                },
                commandType: CommandType.StoredProcedure);
            }
        }

        public void Alterar(Contato contato)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_ALTERARCONTATO",
                new
                {
                    @IDCONTATO = contato.IdContato,
                    @NOME = contato.Nome
                },
                commandType: CommandType.StoredProcedure);
            }
        }

        public void Excluir(Contato contato)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_EXCLUIRCONTATO",
                new
                {
                    @IDCONTATO = contato.IdContato
                },
                commandType: CommandType.StoredProcedure);
            }
        }

        public List<Contato> Consultar()
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection
                .Query<Contato>("SP_CONSULTARCONTATOS",
               commandType: CommandType.StoredProcedure)
               .ToList();
            }
        }

        public Contato ObterPorId(Guid idContato)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection
                .Query<Contato>("SP_OBTERCONTATOPORID",
               new
               {
                   @IDCONTATO = idContato
               },
               commandType: CommandType.StoredProcedure)
               .FirstOrDefault();
            }
        }
    }
}
