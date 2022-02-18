using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebApi.Models;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BookController : ApiController
    {
        WebApiContext _Context = new WebApiContext();


        /// <summary>
        /// Que estoy consultando en el metodo GetAll?
        /// Estoy devolviendo una lista de libros
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Book/GetAll")]
        
        public ICollection<Book> GetAll()
        {

            return _Context.Book.ToList();
        }


        /// <summary>
        /// Consultando libros por Autor,Genero y por Titulo
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Book/GetSearchCriteria/{criteria}")]
        public ICollection<Book> GetSearchCriteria(string criteria)
        {

            return _Context.Book.Where(x=>x.Autor.Contains(criteria) || 
            x.Genero.Contains(criteria)|| x.Titulo.Contains(criteria)).ToList();
        }


        /// <summary>
        /// Seleccionando un único libro por medio del bookId
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Book/GetByBookId/{bookId}")]
        public Book GetByBookId(int bookId)
        {

            return _Context.Book.Where(x => x.BookId==bookId).FirstOrDefault();
        }


        /// <summary>
        /// Creando nuevo libro
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Book/Create")]
        public ICollection<Book> Create([FromBody]Book book)
        {

            var books = _Context.Set<Book>();
            books.Add(book);

            _Context.SaveChanges();

            return GetAll();
        }


        
    }
}
