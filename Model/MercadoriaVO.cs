using Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MercadoriaVO : Entity 
    {
        public String Descricao { get; set; }

        public long? CodBarras { get; set; }

        public long? IdLocalEstoqueEntrada { get; set; }

        public long? IdLocalEstoqueSaida { get; set; }

        public long TipoMercadoria { get; set; }
    }
}
