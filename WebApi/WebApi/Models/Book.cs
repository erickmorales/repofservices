using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Publicacion { get; set; }
        public string Genero { get; set;}
        public int Stock { get; set; }
    }
}