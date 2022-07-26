using Repository.Projeto.Implementacao;
using Repository.Projeto.Interface;

namespace Repository.Projeto.Base
{
    public class RepositorioFactory
    {
        #region Propriedades

        public IRepositorioUsuario RepositorioUsuario { get; set; }

        public IRepositorioTipoPreco RepositorioTipoPreco { get; set; }

        public IRepositorioCidadeEstado RepositorioCidadeEstado { get; set; }

        public IRepositorioParceiroNegocio RepositorioParceiroNegocio { get; set; }

        public IRepositorioLocalEstoque RepositorioLocalEstoque { get; set; }

        public IRepositorioMercadoria RepositorioMercadoria { get; set; }

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

            this.RepositorioCidadeEstado = new RepositorioCidadeEstado();

            this.RepositorioParceiroNegocio = new RepositorioParceiroNegocio();

            this.RepositorioLocalEstoque = new RepositorioLocalEstoque();

            this.RepositorioMercadoria = new RepositorioMercadoria();
        }

        #endregion
    }
}
