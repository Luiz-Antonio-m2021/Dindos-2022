using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UsuarioPNVO
    {
        public long? Id { get; set; }
        public string NomeRazao { get; set; }
        public String Logon { get; set; }        
        public String Senha { get; set; }

        public Boolean Ativo { get; set; }

        public String AtivoProxy
        {
            get
            {
                //return this.AtivoT ? "ATIVO" : "INATIVO";

                if (this.Ativo)
                {
                    return "Ativo";
                }
                else
                {
                    return "Inativo";
                }
            }
        }
    }
}
