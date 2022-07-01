using System;
using System.Collections.Generic;

namespace Repository.Projeto.Base
{
    public interface IRepositorio
    {
        IEnumerable<T> ConsultaTodos<T>();
    }
}
