using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraAspCore.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public List<ItemPedido> Itens { get; private set; }
        public decimal TotalCarrinho { get { return CalculaTotalCarrinho(); } }

        public CarrinhoViewModel(List<ItemPedido> itemPedidos) 
        {
            this.Itens = itemPedidos;
        }

        private decimal CalculaTotalCarrinho()
        {
            if (this.Itens.Count > 0)
            {
                return this.Itens.Sum(i => i.Subtotal);
            }
            else
                return 0;
        }

    }
}
