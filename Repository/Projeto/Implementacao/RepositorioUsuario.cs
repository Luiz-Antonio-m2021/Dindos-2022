using Dapper;
using Model;
using Repository.Projeto.Base;
using Repository.Projeto.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Repository.Projeto.Implementacao
{
    public class RepositorioUsuario : ARepositorio, IRepositorioUsuario
    {
        public override IEnumerable<T> ConsultaTodos<T>()
        {
            using (SqlConnection conexao = new SqlConnection(this.StringConexao))
            {
                conexao.Open();

                using (SqlTransaction transacao = conexao.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @" SELECT 
                                        usuario.Id, usuario.Logon, usuario.Ativo, parceiro.NomeRazao, usuario.senha
                                    FROM
                                        CAD_Usuario usuario
                                        INNER JOIN CAD_ParceiroNegocio parceiro ON parceiro.Id = usuario.Id";

                    return conexao.Query<T>(sql, transaction: transacao);
                }
            }
        }

        public void SalvarOuAtualizaUsuario(UsuarioPNVO usuario)
        {
            using (SqlConnection conexao = new SqlConnection(this.StringConexao))
            {
                conexao.Open();

                using (SqlTransaction transacao = conexao.BeginTransaction())
                {
                    String sqlValidaUsuarioExistente = "SELECT Id FROM CAD_Usuario WHERE Id = @id";

                    object objret = conexao.QueryFirstOrDefault(sqlValidaUsuarioExistente, new { id = usuario.Id }, transacao);

                    //Salvar novo cadastro
                    if (objret == null)
                    {
                        String sql = "INSERT INTO CAD_Usuario (Id, Logon, Senha, Ativo) VALUES (@id, @logon, @senha, 1)";

                        conexao.Execute(sql, new
                        {
                            id = usuario.Id,
                            logon = usuario.Logon,
                            senha = usuario.Senha,
                        }, transacao);
                    }                    
                    else
                    {
                        String sql = "UPDATE CAD_Usuario SET Logon = @Logon, Senha = @Senha, Ativo = @ativo WHERE Id = @Id";

                        conexao.Execute(sql, new
                        {
                            logon = usuario.Logon,
                            senha = usuario.Senha,
                            id = usuario.Id,
                            ativo = usuario.Ativo
                        }, transacao);
                    }

                    transacao.Commit();
                }
            }
        }

        public Boolean ValidarParceiro(long id)
        {
            using (SqlConnection con = new SqlConnection(this.StringConexao))
            {
                con.Open();

                String sql = "SELECT Id FROM CAD_Usuario WHERE id = @id	";

                object obj = con.QueryFirstOrDefault(sql, new { id = id});

                if (obj == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
