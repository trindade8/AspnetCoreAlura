using AluraAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraAspCore
{
    public class DataService : IDataService
    {
        private readonly Contexto contexto;
 

        public DataService(Contexto contexto)
        {
            this.contexto = contexto;

            



        }

        public List<ItemPedido> GetItensPedido()
        {
            return this.contexto.ItensPedido.ToList();
        }

        public List<Produto> GetProdutos()
        {
            return this.contexto.Produtos.ToList();
        }

        public void InicializaDB()
        {
            this.contexto.Database.EnsureCreated();
            if (this.contexto.Produtos.Count().Equals(0))
            {
                List<Produto> produtos = new List<Produto>{
            new Produto("Sleep not found", 59.90m ),
            new Produto("May the code be with you", 59.90m ),
            new Produto("Rollback",59.90m ),
            new Produto("REST",  69.90m),
            new Produto("Design Patterns com Java",  69.90m ),
            new Produto("Vire o jogo com Spring Framework",  69.90m ),
            new Produto("Test-Driven Development",  69.90m ),
            new Produto("iOS: Programe para iPhone e iPad",  69.90m ),
            new Produto("Desenvolvimento de Jogos para Android",  69.90m )
            };

                foreach (Produto p in produtos)
                {
                    this.contexto.Produtos.Add(p);
                    this.contexto.ItensPedido.Add(new ItemPedido(p, 1));

                }
                this.contexto.SaveChanges();

            }

        }
    }
}
