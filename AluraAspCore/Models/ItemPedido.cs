using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraAspCore.Models
{
    public class ItemPedido
    {
        public int Id { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public Decimal PrecoUnitario { get; private set; }
        public Decimal Subtotal { get { return Quantidade * PrecoUnitario; } }

        public ItemPedido(int id, Produto produto, int quantidade, decimal precoUnitario)
        {
            this.Id = id;
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitario = precoUnitario;
        }

    }
}
