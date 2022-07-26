using Dapper;
using Model;
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
    public class RepositorioLocalEstoque : ARepositorio, IRepositorioLocalEstoque
    {
        public override IEnumerable<T> ConsultaTodos<T>()
        {
            using (SqlConnection con = new SqlConnection(this.StringConexao))
            {
                con.Open();
                using (SqlTransaction transacao = con.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @"SELECT * FROM CAD_LocalEstoque";

                    return con.Query<T>(sql, transaction: transacao);
                }
            }
        }
        public IEnumerable<T> ConsultaTodosAtivos<T>()
        {
            using (SqlConnection con = new SqlConnection(this.StringConexao))
            {
                con.Open();
                using (SqlTransaction transacao = con.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @"SELECT * FROM CAD_LocalEstoque WHERE Ativo = 1";

                    return con.Query<T>(sql, transaction: transacao);
                }
            }
        }
    }
}
