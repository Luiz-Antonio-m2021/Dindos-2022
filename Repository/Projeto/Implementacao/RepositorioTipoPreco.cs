using Model;
using Dapper;
using Repository.Projeto.Base;
using Repository.Projeto.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Projeto.Implementacao
{
    public class RepositorioTipoPreco : ARepositorio, IRepositorioTipoPreco
    {
        public override IEnumerable<T> ConsultaTodos<T>()
        {
            using (SqlConnection conexao = new SqlConnection(this.StringConexao))
            {
                conexao.Open();

                using (SqlTransaction transacao = conexao.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @"SELECT * FROM CAD_TipoPreco";

                    return conexao.Query<T>(sql, transaction: transacao);
                }
            }
        }

        public void SalvarAtualizarTipoPreco(TipoPrecoVO tipoPreco)
        {
            using (SqlConnection con = new SqlConnection(this.StringConexao))
            {
                con.Open();

                using (SqlTransaction trans = con.BeginTransaction())
                {
                    //Cadastrar novo tipo de preço
                    if (tipoPreco.Id <= 0)
                    {
                        String sql = "INSERT INTO CAD_TipoPreco (Descricao, Ativo) VALUES (@Descricao, @Ativo)";

                        con.Execute(sql, new
                        {
                            Descricao = tipoPreco.Descricao,
                            Ativo = tipoPreco.Ativo
                        }, trans);
                    }
                    //Altera os dados do cadastro
                    else
                    {
                        String sql = "UPDATE CAD_TipoPreco SET Descricao = @Descricao, Ativo = @Ativo WHERE Id = @Id";

                        con.Execute(sql, new {
                            Descricao = tipoPreco.Descricao,
                            Ativo = tipoPreco.Ativo,
                            Id = tipoPreco.Id
                        }, trans);
                    }

                    trans.Commit();
                }
            }

        }

    }
}
