using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Base;

namespace Model
{
    public class MercadoriaPrecoVO
    {
        //public long? IdMercadoria { get; set; }

        public long IdTipoPreco { get; set; }

        public Decimal PrecoMercadoria { get; set; }

        public int Prioridade { get; set; }

        public String DescricaoPreco { get; set; }
    }
}
