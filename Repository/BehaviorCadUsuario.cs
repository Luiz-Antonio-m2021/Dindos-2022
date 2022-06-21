using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Repository
{
    public class BehaviorCadUsuario
    {
        #region Crud

        public void CadastrarUsuario(int Id, String Logon, String Senha)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn.StrConn))
                {
                    cn.Open();

                    var sql = "INSERT INTO CAD_Usuario VALUES (@ID, @LOGON, @SENHA, 1)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@ID", Id);
                        cmd.Parameters.AddWithValue("@LOGON", Logon);
                        cmd.Parameters.AddWithValue("@SENHA", Senha);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao inserir os dados! \n" + ex);
            }
        }

        #endregion

        #region Carregar Campos

        public List<UsuarioPNVO> CarregarComboPN()
        {
            SqlConnection cn = new SqlConnection(conn.StrConn);
            List<UsuarioPNVO> lstRetorno = new List<UsuarioPNVO>();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT PN.Id, PN.NomeRazao FROM CAD_ParceiroNegocio PN"
                                + " LEFT JOIN CAD_Usuario US ON PN.Id = US.Id"
                                +" WHERE PN.Tipo_PN in (1, 7)"
                                + " AND PN.Ativo = 1"
                                + " AND US.Id IS NULL"
                                +" OR US.Ativo = 0";
            cmd.Connection = cn;

            try
            {
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UsuarioPNVO objVo = new UsuarioPNVO();

                    objVo.Id = Convert.ToInt32(dr["Id"]);
                    objVo.NomeRazao = dr["NomeRazao"].ToString();

                    lstRetorno.Add(objVo);
                }
                if (dr.HasRows)
                {
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar a Combo de Parceiro! \n" + ex.Message);
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

        public List<UsuarioPNVO> CarregarDgvPesquisa()
        {
            SqlConnection cn = new SqlConnection(conn.StrConn);
            List<UsuarioPNVO> lstRetorno = new List<UsuarioPNVO>();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT PN.Id, PN.NomeRazao, US.Logon, US.Ativo FROM CAD_ParceiroNegocio PN "
                                +"Right JOIN CAD_Usuario US ON PN.Id = US.Id";
            cmd.Connection = cn;

            try
            {
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UsuarioPNVO objVo = new UsuarioPNVO();

                    objVo.Id = Convert.ToInt32(dr["Id"]);
                    objVo.NomeRazao = dr["NomeRazao"].ToString();
                    objVo.Logon = dr["Logon"].ToString();
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
                MessageBox.Show("Não foi possivel carregar a grid de Usuarios! \n" + ex.Message);
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
