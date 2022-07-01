using Model;
using Repository.Projeto.Base;
using System;

namespace Repository.Projeto.Interface
{
    public interface IRepositorioUsuario : IRepositorio
    {
        void SalvarOuAtualizaUsuario(UsuarioPNVO usuario);

        Boolean ValidarParceiro(long id);
    }
}
