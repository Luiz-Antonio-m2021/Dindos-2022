using Model;
using Repository.Projeto.Base;
using System;

namespace Repository.Projeto.Interface
{
    public interface IRepositorioTipoPreco : IRepositorio
    {
        void SalvarAtualizarTipoPreco(TipoPrecoVO tipoPreco);



    }
}
