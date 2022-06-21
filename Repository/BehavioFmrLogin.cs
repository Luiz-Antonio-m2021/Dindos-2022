using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Repository
{
    public class BehavioFmrLogin
    {
        public Boolean RealizarLogin(String Login, String Senha)
        {
            SqlConnection cn = new SqlConnection(conn.StrConn);
            SqlCommand cmd = new SqlCommand();
            bool ret = true;

            cmd.CommandText = "SELECT * FROM FN_ValidarLoginUsuario_Table(@Login, @Senha)";
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            cmd.Connection = cn;

            try
            {
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.HasRows)
                {
                    ret = false;
                }
                else
                {
                    while (dr.Read())
                    {
                        UsuarioVO.Id = Convert.ToInt32(dr["Id"]);
                        UsuarioVO.Login = dr["Logon"].ToString();
                        UsuarioVO.NomeCompleto = dr["NomeCompleto"].ToString();
                    }
                    if (dr.HasRows)
                    {
                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel realizar o Login! \n" + ex.Message);
                ret = false;
            }
            finally
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

            return ret;

        }
    }
}
