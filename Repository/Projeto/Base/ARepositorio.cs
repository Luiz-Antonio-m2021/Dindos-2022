using System;
using System.Collections.Generic;

namespace Repository.Projeto.Base
{
    public abstract class ARepositorio : IRepositorio
    {
        #region Propriedades

        private static string server = "META_ANTONIO";
        private static string db = "Sistema_Vendas";
        private static string user = "sa";
        private static string senha = "kb74Uwfcq/DRfmAGZd8pkghc52rMpXAGBZXVQOr4pkpIpsK5nt6pDCJE+EF+47wZY8aX87eqCtt/F9vjKBHMNk8jJ/2oVXOtGBcUEMn9cb1txI0Fiv7N+LFzgcfWGJuW";

        protected string StringConexao
        {
            get { return "Data Source=" + server + "; Integrated Security=false; Initial Catalog=" + db + "; User ID=" + user + "; Password=" + senha; }
        }

        #endregion

        #region Métodos

        public abstract IEnumerable<T> ConsultaTodos<T>();

        #endregion
    }
}


