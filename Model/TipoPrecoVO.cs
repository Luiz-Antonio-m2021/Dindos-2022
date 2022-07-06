using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoPrecoVO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Boolean Ativo { get; set; }

        public String AtivoProxy
        {
            get
            {
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
