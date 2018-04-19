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


        public ItemPedido()
        {

        }
        public ItemPedido(int id, Produto produto, int quantidade)
            :this(produto,quantidade)
        {
            this.Id = id;
            
        }

        public ItemPedido( Produto produto, int quantidade)
        {           
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitario = produto.Preco;
        }


    }
}
