﻿using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
	public class CarrinhoCompraController : Controller
	{
		private readonly CarrinhoCompra _carrinhoCompra;
		private readonly IProdutoRepository _produtoRepository;
		public CarrinhoCompraController(CarrinhoCompra carrinhoCompra, IProdutoRepository produtoRepository)
		{
			_carrinhoCompra = carrinhoCompra;
			_produtoRepository = produtoRepository;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult AdicionarItem(int id)
		{
			Produto produto = _produtoRepository.ObterProduto(id);
			if (produto == null)
			{
				return View();
			}
			else
			{
				var item = new Item() { Id = id, Quantidade = 1};
				_carrinhoCompra.Cadastrar(item);

				return RedirectToAction(nameof(Index));
			}
		}

		public IActionResult AlterarQuantidade()
		{
			return View();
		}

		public IActionResult RemoverItem()
		{
			return View();
		}
	}
}