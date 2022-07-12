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
    public class RepositorioParceiroNegocio : ARepositorio, IRepositorioParceiroNegocio
    {

        public override IEnumerable<T> ConsultaTodos<T>()
        {
            using (SqlConnection conexao = new SqlConnection(this.StringConexao))
            {
                conexao.Open();

                using (SqlTransaction transacao = conexao.BeginTransaction(IsolationLevel.ReadUncommitted))
                {
                    String sql = @"SELECT 
                                	PN.Id,
                                	PN.CpfCnpj,
                                	PN.NomeRazao,
                                	PN.RGIE,
                                	PN.Email,
                                	PN.Telefone,
                                	PN.Logradouro,
                                	PN.Bairro,
                                	PN.CEP,
                                	PN.Ativo,
                                	PN.Tipo_PN AS TipoPN,
                                	AP.IdTipoPreco AS IdPrecoAPrazo,
                                	AP.Ativo AS PrazoAtivo,
                                	AV.IdTipoPreco AS IdPrecoAVista,
                                	AV.Ativo AS VistaAtivo,
                                	CID.Id AS IdCidade,
                                	CID.Descricao AS DescCidade,
                                	EST.Id AS IdEstado,
                                	EST.Descricao as DescEstado
                                 FROM CAD_ParceiroNegocio AS PN
                                LEFT JOIN CAD_PN_TipoAPrazo AS AP ON PN.Id = AP.Id
                                LEFT JOIN CAD_PN_TipoAVista AS AV ON PN.Id = AV.Id
                                LEFT JOIN CAD_Cidade AS CID ON PN.IdCidade = CID.Id
                                LEFT JOIN CAD_Estado AS EST ON CID.IdEstado = EST.Id";

                    return conexao.Query<T>(sql, transaction: transacao);
                }
            }
        }

        public void SalvarOuAtualizarParceiro(ParceiroNegocioVO parceiro)
        {
            using(SqlConnection con = new SqlConnection(this.StringConexao))
            {
                con.Open();

                using(SqlTransaction trans = con.BeginTransaction())
                {
                    if (parceiro.Id is null)
                    {
                        String sql = @"INSERT INTO CAD_ParceiroNegocio (IdCidade, NomeRazao, CpfCnpj, RGIE, Telefone, Logradouro, Bairro, Ativo, Tipo_PN, Email, CEP)
                                         VALUES 
                                        (@IdCidade, @NomeRazao, @CpfCnpj, @RGIE, @Telefone, @Logradouro, @Bairro, @Ativo, @Tipo_PN, @Email, @CEP)";

                        con.Execute(sql, new {
                            IdCidade = parceiro.IdCidade,
                            NomeRazao = parceiro.NomeRazao,
                            CpfCnpj = parceiro.CpfCnpj,
                            RGIE = parceiro.RGIE,
                            Telefone = parceiro.Telefone,
                            Logradouro = parceiro.Logradouro,
                            Bairro = parceiro.Bairro,
                            Ativo = parceiro.Ativo,
                            Tipo_PN = parceiro.TipoPN,
                            Email = parceiro.Email,
                            CEP = parceiro.CEP
                        }, trans);

                        //trans.Commit();

                        sql = @"SELECT TOP(1) * FROM CAD_ParceiroNegocio ORDER BY Id DESC";
                        //ParceiroNegocioVO newPN = new ParceiroNegocioVO();
                        IEnumerable<ParceiroNegocioVO> newPN = con.Query<ParceiroNegocioVO>(sql, transaction: trans);
                        List<ParceiroNegocioVO> lstNewPN = newPN.ToList();
                        
                        for (int i = 0; i < lstNewPN.Count(); i++)
                        {
                            parceiro.Id = lstNewPN[i].Id;
                        }

                        if (parceiro.IdPrecoAPrazo > 0)
                        {
                            sql = @"INSERT INTO CAD_PN_TipoAPrazo VALUES (@Id, @IdPrecoAPrazo, 1)";

                            con.Execute(sql, new {
                                Id = parceiro.Id,
                                IdPrecoAPrazo = parceiro.IdPrecoAPrazo
                            }, trans);

                        }
                        if (parceiro.IdPrecoAVista > 0)
                        {
                            sql = @"INSERT INTO CAD_PN_TipoAVista VALUES (@Id, @IdPrecoAVista, 1)";

                            con.Execute(sql, new
                            {
                                Id = parceiro.Id,
                                IdPrecoAVista = parceiro.IdPrecoAVista
                            }, trans);

                        }
                    }
                    else
                    {
                        String sql = @"UPDATE CAD_ParceiroNegocio 
                                        SET 
                                          IdCidade = @IdCidade, 
                                          NomeRazao = @NomeRazao, 
                                          CpfCnpj = @CpfCnpj, 
                                          RGIE = @RGIE, 
                                          Telefone = @Telefone, 
                                          Logradouro = @Logradouro, 
                                          Bairro = @Bairro, 
                                          Ativo = @Ativo, 
                                          Tipo_PN = @Tipo_PN, 
                                          Email = @Email, 
                                          CEP = @CEP
                                        WHERE Id = @Id";

                        con.Execute(sql, new
                        {
                            Id = parceiro.Id,
                            IdCidade = parceiro.IdCidade,
                            NomeRazao = parceiro.NomeRazao,
                            CpfCnpj = parceiro.CpfCnpj,
                            RGIE = parceiro.RGIE,
                            Telefone = parceiro.Telefone,
                            Logradouro = parceiro.Logradouro,
                            Bairro = parceiro.Bairro,
                            Ativo = parceiro.Ativo,
                            Tipo_PN = parceiro.TipoPN,
                            Email = parceiro.Email,
                            CEP = parceiro.CEP
                        }, trans);

                        if (!parceiro.PrazoAtivo)
                        {
                            sql = @"UPDATE CAD_PN_TipoAPrazo SET Ativo = @Ativo WHERE Id = @Id";

                            con.Execute(sql, new {
                                Ativo = parceiro.PrazoAtivo,
                                Id = parceiro.Id
                            }, trans);
                        }
                        if (parceiro.PrazoAtivo)
                        {
                            string sqlConsultaExistePrecoCadastrado = "SELECT id FROM CAD_PN_TipoAPrazo WHERE Id = @Id";

                            object prazo = con.QueryFirstOrDefault(sqlConsultaExistePrecoCadastrado, new {
                                Id = parceiro.Id,
                            }, trans);

                            if (prazo == null)
                            {
                                sql = @"INSERT INTO CAD_PN_TipoAPrazo VALUES (@Id, @IdPrecoAPrazo, 1)";

                                con.Execute(sql, new
                                {
                                    Id = parceiro.Id,
                                    IdPrecoAPrazo = parceiro.IdPrecoAPrazo
                                }, trans);
                            }
                        }
                        if (!parceiro.VistaAtivo)
                        {
                            sql = @"UPDATE CAD_PN_TipoAVista SET Ativo = @Ativo WHERE Id = @Id";

                            con.Execute(sql, new
                            {
                                Ativo = parceiro.VistaAtivo,
                                Id = parceiro.Id
                            }, trans);
                        }
                        if (parceiro.VistaAtivo)
                        {
                            string sqlConsultaExistePrecoCadastrado = "SELECT * FROM CAD_PN_TipoAVista WHERE Id = @Id";

                            object vista = con.QueryFirstOrDefault(sqlConsultaExistePrecoCadastrado, new
                            {
                                Id = parceiro.Id,
                            }, trans);

                            if (vista == null)
                            {
                                sql = @"INSERT INTO CAD_PN_TipoAVista VALUES (@Id, @IdPrecoAVista, 1)";

                                con.Execute(sql, new
                                {
                                    Id = parceiro.Id,
                                    IdPrecoAVista = parceiro.IdPrecoAVista
                                }, trans);
                            }
                        }
                    }

                    trans.Commit();
                }
            }
        }
    }
}
