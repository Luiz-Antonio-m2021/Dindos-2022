using Model;
using Repository.Projeto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Projeto.Interface
{
    public interface IRepositorioMercadoria : IRepositorio
    {

        void SalvarOuAtualizarMercadoria(MercadoriaVO mercadoria, List<MercadoriaComboKitVO> combo, List<MercadoriaPrecoVO> preco);

        

    }
}
