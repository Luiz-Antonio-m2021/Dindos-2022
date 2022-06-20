using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Model;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Repository
{
    
    public class BehaviorFmrCadTipoPreco 
    {
        #region Crud
        public void CadastrarTipoPreco(String Descricao)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.StrConn))
                {
                    cn.Open();

                    var sql = "insert into CAD_TipoPreco (Descricao, Ativo) values(@Desc, 1)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Desc", Descricao);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao inserir os dados! \n"+ ex);
            }
        }

        public void AlterarTipoPreco(TipoPrecoVO objVo)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.StrConn))
                {
                    cn.Open();

                    var sql = "UPDATE CAD_TipoPreco SET Descricao = @Desc, Ativo = 1 WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Desc", objVo.Descricao);
                        cmd.Parameters.AddWithValue("@Id", objVo.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao alterar os dados! \n" + ex);
            }
        }

        public void InativarTipoPreco(int Ativo, int Id)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.StrConn))
                {
                    cn.Open();

                    var sql = "UPDATE CAD_TipoPreco SET Ativo = @Ativo WHERE ID = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Ativo", Ativo);
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao inativar os dados! \n" + ex);
            }
        }
        #endregion

        #region Metodos

        public List<TipoPrecoVO> CarregarTiposPreco()
        {
            SqlConnection cn = new SqlConnection(conn.StrConn);
            SqlCommand cmd = new SqlCommand();
            List<TipoPrecoVO> lstRetorno = new List<TipoPrecoVO>();

            cmd.CommandText = "select * from CAD_TipoPreco";
            cmd.Connection = cn;

            try
            {
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TipoPrecoVO objVo = new TipoPrecoVO();

                    objVo.Id = Convert.ToInt32(dr["Id"]);
                    objVo.Descricao = dr["Descricao"].ToString();
                    //objVo.Ativo = dr["Ativo"].ToString() == "true" ? "Ativo" : "Inativo";
                    objVo.Ativo = Convert.ToBoolean(dr["Ativo"]) == true ? "Ativo" : "Inativo";

                    lstRetorno.Add(objVo);
                }
                if (dr.HasRows)
                {
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel realizar a pesquisa! \n" + ex.Message);
            }
            finally
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return lstRetorno;
        }
        #endregion
    }
}
