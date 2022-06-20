using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class conn
    {
        public static string server = "META_ANTONIO";
        public static string db = "Sistema_Vendas";
        public static string user = "sa";
        public static string senha = "kb74Uwfcq/DRfmAGZd8pkghc52rMpXAGBZXVQOr4pkpIpsK5nt6pDCJE+EF+47wZY8aX87eqCtt/F9vjKBHMNk8jJ/2oVXOtGBcUEMn9cb1txI0Fiv7N+LFzgcfWGJuW";
        public static string StrConn
        {
            get { return "Data Source=" + server + "; Integrated Security=false; Initial Catalog=" + db + "; User ID=" + user + "; Password=" + senha; }
        }
    }
}
