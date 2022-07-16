using Model.Base;
using System;

namespace Model
{
    public class UsuarioPNVO : Entity
    {
        public string NomeRazao { get; set; }
        public String Logon { get; set; }        
        public String Senha { get; set; }
    }
}
