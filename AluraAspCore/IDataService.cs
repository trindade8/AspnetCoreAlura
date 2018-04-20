using AluraAspCore.Models;
using System.Collections.Generic;

namespace AluraAspCore
{
    public interface IDataService
    {
        void InicializaDB();
        List<Produto> GetProdutos();
        List<ItemPedido> GetItensPedido();
    }
}