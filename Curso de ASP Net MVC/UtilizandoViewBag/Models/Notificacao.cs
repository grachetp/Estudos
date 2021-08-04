using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilizandoViewBag.Models
{
    public class Notificacao
    {
		public int Id { get; set; }
		public string Titulo { get; set; }

		public Notificacao(int id, string titulo)
		{
			Id = id;
			Titulo = titulo;
		}
	}
}