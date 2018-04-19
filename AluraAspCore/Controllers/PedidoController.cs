using AluraAspCore.Models;
using AluraAspCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraAspCore.Controllers
{
    public class PedidoController : Controller
    {
        List<Produto> produtos = new List<Produto>{
        new Produto( 1, "Sleep not found", 59.90m ),
        new Produto( 2, "May the code be with you", 59.90m ),
        new Produto( 3, "Rollback",59.90m ),
        new Produto( 4, "REST",  69.90m),
        new Produto( 5, "Design Patterns com Java",  69.90m ),
        new Produto( 6, "Vire o jogo com Spring Framework",  69.90m ),
        new Produto( 7, "Test-Driven Development",  69.90m ),
        new Produto( 8, "iOS: Programe para iPhone e iPad",  69.90m ),
        new Produto( 9, "Desenvolvimento de Jogos para Android",  69.90m )
        };

        public IActionResult Carrossel()
        {
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel CarrinhoViewModel = GetCarrinhoViewModel();

            return View(CarrinhoViewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            var ItensCarrinho = new List<ItemPedido>()
            {
                new ItemPedido(this.produtos[0] ,1),
                new ItemPedido(this.produtos[1],2),
                new ItemPedido( 3, this.produtos[2],1),
                new ItemPedido( 4, this.produtos[3],3)
            };

            var CarrinhoViewModel = new CarrinhoViewModel(ItensCarrinho);
            return CarrinhoViewModel;
        }

        public IActionResult Resumo()
        {
            return View(GetCarrinhoViewModel());
        }
    }
}
