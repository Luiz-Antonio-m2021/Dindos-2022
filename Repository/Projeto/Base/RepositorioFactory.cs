using Repository.Projeto.Implementacao;
using Repository.Projeto.Interface;

namespace Repository.Projeto.Base
{
    public class RepositorioFactory
    {
        #region Propriedades

        public IRepositorioUsuario RepositorioUsuario { get; set; }

        public IRepositorioTipoPreco RepositorioTipoPreco { get; set; }

        #endregion

        #region Singleton

        private static RepositorioFactory instancia;

        public static RepositorioFactory Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new RepositorioFactory();
                }

                return instancia;
            }
        }

        private RepositorioFactory()
        {
            this.RepositorioUsuario = new RepositorioUsuario();

            this.RepositorioTipoPreco = new RepositorioTipoPreco();
        }

        #endregion
    }
}
