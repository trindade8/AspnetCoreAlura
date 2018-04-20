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
        private readonly IDataService _idataService;



        public PedidoController(IDataService dataService)
        {
            _idataService = dataService;
        }

        public IActionResult Carrossel()
        {
            List<Produto> produtos = _idataService.GetProdutos();
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel CarrinhoViewModel = GetCarrinhoViewModel();

            return View(CarrinhoViewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            List<Produto> produtos = this._idataService.GetProdutos();

            //var ItensCarrinho = new List<ItemPedido>()
            //{
            //    new ItemPedido(produtos[0] ,1),
            //    new ItemPedido(produtos[1],2),
            //    new ItemPedido( 3, produtos[2],1),
            //    new ItemPedido( 4, produtos[3],3)
            //};
            //var CarrinhoViewModel = new CarrinhoViewModel(ItensCarrinho);

            var ItensCarrinho = this._idataService.GetItensPedido();
            var CarrinhoViewModel = new CarrinhoViewModel(ItensCarrinho);
            return CarrinhoViewModel;
        }

        public IActionResult Resumo()
        {
            return View(GetCarrinhoViewModel());
        }
    }
}
