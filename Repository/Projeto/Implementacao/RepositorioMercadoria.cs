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
    public class RepositorioMercadoria : ARepositorio, IRepositorioMercadoria
    {

        public override IEnumerable<T> ConsultaTodos<T>()
        {
            using (SqlConnection con = new SqlConnection(this.StringConexao))
            {
                con.Open();
                using (SqlTransaction transacao = con.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @"SELECT * FROM CAD_Mercadoria";

                    return con.Query<T>(sql, transaction: transacao);
                }
            }
        }

        public void SalvarOuAtualizarMercadoria(MercadoriaVO mercadoria, List<MercadoriaComboKitVO> combo, List<MercadoriaPrecoVO> preco)
        {
            //Cadastrar nova Mercadoria
            if (mercadoria.Id is null)
            {
                using (SqlConnection con = new SqlConnection(this.StringConexao))
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction(IsolationLevel.ReadCommitted))
                    {
                        //Tipo Comum
                        if (mercadoria.TipoMercadoria == 0)
                        {
                            string sql_insert = @"INSERT INTO CAD_Mercadoria 
                                            VALUES
                                            (@Descricao, @CodBarras, @IdLocalEstoqueEntrada, @IdLocalEstoqueSaida, @Ativo, @TipoMercadoria);";

                            con.Execute(sql_insert, new
                            {
                                Descricao = mercadoria.Descricao,
                                CodBarras = mercadoria.CodBarras,
                                IdLocalEstoqueEntrada = mercadoria.IdLocalEstoqueEntrada,
                                IdLocalEstoqueSaida = mercadoria.IdLocalEstoqueSaida,
                                Ativo = mercadoria.Ativo,
                                TipoMercadoria = mercadoria.TipoMercadoria
                            }
                            , trans);

                            string sql_consulta = @"SELECT TOP(1) * FROM CAD_Mercadoria ORDER BY Id DESC";

                            IEnumerable<MercadoriaVO> lstMerc = con.Query<MercadoriaVO>(sql_consulta, transaction: trans);
                            List<MercadoriaVO> lstNewMerc = lstMerc.ToList();

                            for (int i = 0; i < lstMerc.Count(); i++)
                            {
                                mercadoria.Id = lstNewMerc[i].Id;
                            }

                            sql_insert = @"INSERT INTO CAD_Mercadoria_has_TipoPreco
                                            VALUES
                                            (@IdMercadoria, @IdTipoPreco, @PrecoMercadoria, @Prioridade);";

                            for (int i = 0; i < preco.Count; i++)
                            {
                                con.Execute(sql_insert, new
                                {
                                    IdMercadoria = mercadoria.Id,
                                    IdTipoPreco = preco[i].IdTipoPreco,
                                    PrecoMercadoria = preco[i].PrecoMercadoria,
                                    Prioridade = preco[i].Prioridade
                                }
                            ,trans);
                            }
                        }
                        //Tipo Combo
                        if (mercadoria.TipoMercadoria == 1)
                        {
                            string sql_insert = @"INSERT INTO CAD_Mercadoria (Descricao,CodBarras,Ativo,TipoMercadoria)
                                            VALUES
                                            (@Descricao, @CodBarras, @Ativo, @TipoMercadoria);";

                            con.Execute(sql_insert, new
                            {
                                Descricao = mercadoria.Descricao,
                                CodBarras = mercadoria.CodBarras,
                                Ativo = mercadoria.Ativo,
                                TipoMercadoria = mercadoria.TipoMercadoria
                            }
                            ,trans);

                            string sql_consulta = @"SELECT TOP(1) * FROM CAD_Mercadoria ORDER BY Id DESC";

                            IEnumerable<MercadoriaVO> lstMerc = con.Query<MercadoriaVO>(sql_consulta, transaction: trans);
                            List<MercadoriaVO> lstNewMerc = lstMerc.ToList();

                            for (int i = 0; i < lstMerc.Count(); i++)
                            {
                                mercadoria.Id = lstNewMerc[i].Id;
                            }

                            sql_insert = @"INSERT INTO CAD_Mercadoria_has_TipoPreco
                                            VALUES
                                            (@IdMercadoria, @IdTipoPreco, @PrecoMercadoria, @Prioridade);";
                            for (int i = 0; i < preco.Count; i++)
                            {
                                con.Execute(sql_insert, new
                                {
                                    IdMercadoria = mercadoria.Id,
                                    IdTipoPreco = preco[i].IdTipoPreco,
                                    PrecoMercadoria = preco[i].PrecoMercadoria,
                                    Prioridade = preco[i].Prioridade
                                }
                            ,trans);
                            }


                            sql_insert = @"INSERT INTO CAD_MercadoriaComboKit
                                            VALUES
                                            (@IdCombo, @IdMercadoriaCombo, @Quantidade)";


                            for (int i = 0; i < combo.Count; i++)
                            {
                                con.Execute(sql_insert, new
                                {
                                    IdCombo = mercadoria.Id,
                                    IdMercadoriaCombo = combo[i].IdMercadoriaCombo,
                                    Quantidade = combo[i].Quantidade
                                }
                            ,trans);
                            }

                        }
                        trans.Commit();
                    }
                }
            }
            else
            {
                using (SqlConnection con = new SqlConnection(this.StringConexao))
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction(IsolationLevel.ReadCommitted))
                    {
                        //Tipo Comum
                        if (mercadoria.TipoMercadoria == 1)
                        {
                            string sql_update = @"UPDATE CAD_Mercadoria 
                                SET Descricao = @Descricao, CodBarras = @CodBarras, IdLocalEstoqueEntrada = @IdLocalEstoqueEntrada, IdLocalEstoqueSaida = @IdLocalEstoqueSaida, 
                                            Ativo = @Ativo, TipoMercadoria = @TipoMercadoria
                                WHERE Id = @Id;";

                            con.Execute(sql_update, new
                            {
                                Descricao = mercadoria.Descricao,
                                CodBarras = mercadoria.CodBarras,
                                IdLocalEstoqueEntrada = mercadoria.IdLocalEstoqueEntrada,
                                IdLocalEstoqueSaida = mercadoria.IdLocalEstoqueSaida,
                                Ativo = mercadoria.Ativo,
                                TipoMercadoria = mercadoria.TipoMercadoria,
                                Id = mercadoria.Id
                            }
                            ,trans);
                            //Limpa os vinculos de preço para inserir os novos
                            string sql_delete = @"DELETE CAD_Mercadoria_has_TipoPreco WHERE IdMercadoria = @Id";

                            con.Execute(sql_delete, new
                            {
                                Id = mercadoria.Id
                            }
                            ,trans);

                            sql_update = @"INSERT INTO CAD_Mercadoria_has_TipoPreco
                                            VALUES
                                            (@IdMercadoria, @IdTipoPreco, @PrecoMercadoria, @Prioridade);";

                            for (int i = 0; i < preco.Count; i++)
                            {
                                con.Execute(sql_update, new
                                {
                                    IdMercadoria = mercadoria.Id,
                                    IdTipoPreco = preco[i].IdTipoPreco,
                                    PrecoMercadoria = preco[i].PrecoMercadoria,
                                    Prioridade = preco[i].Prioridade
                                }
                            ,trans);
                            }
                        }
                        //Tipo Combo
                        if (mercadoria.TipoMercadoria == 2)
                        {
                            string sql_insert = @"UPDATE CAD_Mercadoria 
                                SET Descricao = @Descricao, CodBarras = @CodBarras,
                                            Ativo = @Ativo, TipoMercadoria = @TipoMercadoria
                                WHERE Id = @Id;";

                            con.Execute(sql_insert, new
                            {
                                Descricao = mercadoria.Descricao,
                                CodBarras = mercadoria.CodBarras,
                                Ativo = mercadoria.Ativo,
                                TipoMercadoria = mercadoria.TipoMercadoria
                            }
                            ,trans);
                            //Limpa os vinculos de preço para inserir os novos
                            string sql_delete = @"DELETE CAD_Mercadoria_has_TipoPreco WHERE IdMercadoria = @Id";

                            con.Execute(sql_delete, new
                            {
                                Id = mercadoria.Id
                            }
                            ,trans);

                            sql_insert = @"INSERT INTO CAD_Mercadoria_has_TipoPreco
                                            VALUES
                                            (@IdMercadoria, @IdTipoPreco, @PrecoMercadoria, @Prioridade);";
                            for (int i = 0; i < preco.Count; i++)
                            {
                                con.Execute(sql_insert, new
                                {
                                    IdMercadoria = mercadoria.Id,
                                    IdTipoPreco = preco[i].IdTipoPreco,
                                    PrecoMercadoria = preco[i].PrecoMercadoria,
                                    Prioridade = preco[i].Prioridade
                                }
                            ,trans);
                            }

                            //Limpa os vinculos de combokit para inserir os novos
                            sql_delete = @"DELETE CAD_MercadoriaComboKit WHERE IdCombo = @Id";

                            con.Execute(sql_delete, new
                            {
                                Id = mercadoria.Id
                            }
                            ,trans);


                            sql_insert = @"INSERT INTO CAD_MercadoriaComboKit
                                            VALUES
                                            (@IdCombo, @IdMercadoriaCombo, @Quantidade)";


                            for (int i = 0; i < combo.Count; i++)
                            {
                                con.Execute(sql_insert, new
                                {
                                    IdCombo = mercadoria.Id,
                                    IdMercadoriaCombo = combo[i].IdMercadoriaCombo,
                                    Quantidade = combo[i].Quantidade
                                }
                            ,trans);
                            }
                        }
                        trans.Commit();
                    }
                }
            }
        }

        public IEnumerable<T> ListarTodasMercadoriasAtivas<T>()
        {
            using (SqlConnection con = new SqlConnection(this.StringConexao))
            {
                con.Open();
                using (SqlTransaction transacao = con.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @"SELECT * FROM CAD_Mercadoria WHERE Ativo = 1;";

                    return con.Query<T>(sql, transaction: transacao);
                }
            }
        }
    }
}
