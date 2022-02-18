using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Services
{
    public class BookServices
    {
        WebApiContext _Context = new WebApiContext();
        public Book UpdateStockAfterReserva(int bookId, int cantidad)
        {

            Book book = _Context.Book.Where(x => x.BookId == bookId).FirstOrDefault();

            book.Stock -= cantidad;

            _Context.SaveChanges();

            return book;
        }


        public Book UpdateStockAfterDevolucion(int bookId, int cantidad)
        {

            Book book = _Context.Book.Where(x => x.BookId == bookId).FirstOrDefault();

            book.Stock += cantidad;

            _Context.SaveChanges();

            return book;
        }


    }
}