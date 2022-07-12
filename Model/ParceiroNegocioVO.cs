using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ParceiroNegocioVO
    {
        public long? Id { get; set; }

        public String NomeRazao { get; set; }

        public String CpfCnpj { get; set; }

        public int IdCidade { get; set; }

        public String DescCidade { get; set; }

        public int IdEstado { get; set; }

        public String DescEstado { get; set; }

        public String RGIE { get; set; }

        public String Telefone { get; set; }

        public String Logradouro { get; set; }

        public String Bairro { get; set; }

        public Boolean Ativo { get; set; }

        public int TipoPN { get; set; }

        public String Email { get; set; }

        public String CEP { get; set; }

        ////Sempre recebe valor 2
        //public int APrazo { get; set; }

        ////Sempre revebe o valor 4
        //public int AVista { get; set; }

        ////Sempre Recebe o valor 1
        //public int Funcionario { get; set; }

        public long? IdPrecoAPrazo { get; set; }

        public Boolean PrazoAtivo { get; set; }

        public long? IdPrecoAVista { get; set; }

        public Boolean VistaAtivo { get; set; }

        public Boolean FuncionarioAtivo { get; set; }

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
