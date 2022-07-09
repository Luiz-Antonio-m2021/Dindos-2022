using Model;
using Repository.Projeto.Base;
using System;
using System.Collections.Generic;

namespace Repository.Projeto.Interface
{
    public interface IRepositorioTipoPreco : IRepositorio
    {
        void SalvarAtualizarTipoPreco(TipoPrecoVO tipoPreco);

        IEnumerable<T> ConsultaTodosAtivos<T>();

    }
}
