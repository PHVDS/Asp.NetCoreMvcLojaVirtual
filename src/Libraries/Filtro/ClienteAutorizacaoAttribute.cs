﻿using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Filtro
{
	public class ClienteAutorizacaoAttribute : Attribute, IAuthorizationFilter
	{
		LoginCliente _loginCliente;
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			_loginCliente = (LoginCliente)context.HttpContext.RequestServices.GetService(typeof(LoginCliente));
			Cliente cliente = _loginCliente.GetCliente();
			
			if (cliente == null)
			{
				context.Result = new StatusCodeResult(403);
			}
		}
	}
}
