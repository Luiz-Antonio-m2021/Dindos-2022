using Model;
using Repository.Projeto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Projeto.Interface
{
    public interface IRepositorioCidadeEstado : IRepositorio
    {
        IEnumerable<T> ConsultaCidadeEstado<T>(int Estado);
    }
}
