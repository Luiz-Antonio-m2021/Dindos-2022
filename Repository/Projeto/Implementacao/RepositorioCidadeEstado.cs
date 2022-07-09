using Dapper;
using Repository.Projeto.Base;
using Repository.Projeto.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Projeto.Implementacao
{
    public class RepositorioCidadeEstado : ARepositorio, IRepositorioCidadeEstado
    {
        public override IEnumerable<T> ConsultaTodos<T>()
        {
            using (SqlConnection conexao = new SqlConnection(this.StringConexao))
            {
                conexao.Open();

                using (SqlTransaction transacao = conexao.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @"SELECT * FROM CAD_Estado WHERE Ativo = 1";

                    return conexao.Query<T>(sql, transaction: transacao);
                }
            }
        }
        public IEnumerable<T> ConsultaCidadeEstado<T>(int Estado)
        {
            using (SqlConnection conexao = new SqlConnection(this.StringConexao))
            {
                conexao.Open();

                using (SqlTransaction transacao = conexao.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @"SELECT * FROM CAD_Cidade WHERE IdEstado = @Estado ";

                    return conexao.Query<T>(sql, new { Estado = Estado }, transacao);
                }
            }
        }
    }
}
