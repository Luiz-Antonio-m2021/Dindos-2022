using System;

namespace Model.Base
{
    public class Entity
    {
        public long? Id { get; set; }

        public Boolean Ativo { get; set; }

        #region Propriedades Proxy

        public String AtivoProxy { get { if (this.Ativo) { return "Ativo"; } else { return "Inativo"; } } }

        #endregion
    }
}
