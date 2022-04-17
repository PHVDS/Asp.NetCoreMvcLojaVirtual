﻿using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Areas.Cliente.Controllers
{
	[Area("Cliente")]
	public class HomeController : Controller
	{
		private readonly LoginCliente _loginCliente;
		private readonly IClienteRepository _repositoryCliente;

		public HomeController(LoginCliente loginCliente, IClienteRepository repositoryCliente)
		{
			_loginCliente = loginCliente;
			_repositoryCliente = repositoryCliente;
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login([FromForm]Models.Cliente cliente, string returnUrl = null)
		{
			Models.Cliente clienteDB = _repositoryCliente.Login(cliente.Email, cliente.Senha);
			if (clienteDB != null)
			{
				_loginCliente.Login(clienteDB);

				if (returnUrl == null)
				{
					return new RedirectResult(Url.Action(nameof(Painel)));
				}
				else
				{
					return LocalRedirectPermanent(returnUrl);
				}
			}
			else
			{
				ViewData["MSG_E"] = "Usuario não encontrado, verifique os campos digitados!";
				return View();
			}
		}

		[HttpGet]
		[ClienteAutorizacao]
		public IActionResult Painel()
		{
			return new ContentResult() { Content = "Aqui é o Painel" };
		}

		[HttpGet]
		public IActionResult CadastroCliente()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CadastroCliente([FromForm]Models.Cliente cliente)
		{
			if (ModelState.IsValid)
			{
				_repositoryCliente.Cadastrar(cliente);

				TempData["MSG_S"] = "Cadastro feito com sucesso!";

				return RedirectToAction(nameof(CadastroCliente));
			}
			return View();
		}
	}
}
