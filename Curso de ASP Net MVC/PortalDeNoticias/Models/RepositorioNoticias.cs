using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Pedro Grachet",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsim dolor sit amet, consectetur asipiscing elit, Maecenas facibus torrot id turpis ultrices tincidunt. Ptoin eu abacaxi"
            });
            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Pedro Grachet",
                Data = DateTime.Today.AddDays(-15),
                Conteudo = "Lorem ipsim dolor sit amet, consectetur asipiscing elit, Maecenas facibus torrot id turpis ultrices tincidunt. Ptoin eu abacaxi"
            });
            noticias.Add(new Noticia
            {
                Id = 3,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Pedro Grachet",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Lorem ipsim dolor sit amet, consectetur asipiscing elit, Maecenas facibus torrot id turpis ultrices tincidunt. Ptoin eu abacaxi"
            });
            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Pedro Grachet",
                Data = DateTime.Today.AddDays(-25),
                Conteudo = "Lorem ipsim dolor sit amet, consectetur asipiscing elit, Maecenas facibus torrot id turpis ultrices tincidunt. Ptoin eu abacaxi"
            });
            noticias.Add(new Noticia
            {
                Id = 5,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Pedro Grachet",
                Data = DateTime.Today.AddDays(-20),
                Conteudo = "Lorem ipsim dolor sit amet, consectetur asipiscing elit, Maecenas facibus torrot id turpis ultrices tincidunt. Ptoin eu abacaxi"
            });
        }
    }
}