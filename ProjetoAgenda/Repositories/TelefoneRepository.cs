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
    public class TelefoneRepository : ITelefoneRepository
    {
        private readonly string _connectionstring;

        public TelefoneRepository(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void Inserir(Telefone telefone)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_INSERIRTELEFONE",
                new
                {
                    @NUMERO = telefone.Numero,
                    @IDCONTATO = telefone.IdContato,
                },
                commandType: CommandType.StoredProcedure);
            }

        }

        public void Alterar(Telefone telefone)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_ALTERARTELEFONE",
                new
                {
                    @IDTELEFONE = telefone.IdTelefone,
                    @NUMERO = telefone.Numero,
                    @IDCONTATO = telefone.IdContato,
                },
                commandType: CommandType.StoredProcedure);
            }
        }

        public void Excluir(Telefone telefone)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                connection.Execute("SP_EXCLUIRTELEFONE",
                new
                {
                    @IDTELEFONE = telefone.IdTelefone
                },
                commandType: CommandType.StoredProcedure);
            }

        }

        public List<Telefone> Consultar()
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection
                .Query<Telefone>("SP_CONSULTARTELEFONES",
               commandType: CommandType.StoredProcedure)
               .ToList();
            }
        }

        public Telefone ObterPorId(Guid idTelefone)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection
                .Query<Telefone>("SP_OBTERTELEFONEPORID",
               new
               {
                   @IDTELEFONE = idTelefone
               },
               commandType: CommandType.StoredProcedure)
               .FirstOrDefault();
            }

        }

        public int ObterQuantidadeNumeros(Guid idContato)
        {
            using (var connection = new SqlConnection(_connectionstring))
            {
                return connection
                .Query<int>("SP_OBTERQUANDIDADEDENUMEROS", 
                new {
                        @IDCONTATO = idContato
                },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            }

        }
    }
}
