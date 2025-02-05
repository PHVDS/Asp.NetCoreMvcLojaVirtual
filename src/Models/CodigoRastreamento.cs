﻿using LojaVirtual.Libraries.Lang;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Models
{
    public class CodigoRastreamento
    {
		[Display(Name = "Código de rastreamento")]
		[Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
		[MinLength(5, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
		public string Codigo { get; set; }
    }
}
