using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApi.Models;
using WebApi.Services;
using static WebApi.Constants;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReservaController : ApiController
    {

        WebApiContext _Context = new WebApiContext();
        BookServices _BookServices = new BookServices();

        [HttpPost]
        [Route("api/Reserva/CreateReserva/{bookId}/{userId}/{cantidad}")]
        public ICollection<Reserva> CreateReserva(int bookId, int userId, int cantidad)
        {
            Reserva res = new Reserva
            {
                BookId = bookId,
                UserId = userId,
                Cantidad = cantidad,
                Estado = EstadoReserva.Prestado.ToString(),

                FechaSolicitud = DateTime.Now
            };

            var reservas = _Context.Set<Reserva>();
            reservas.Add(res);

            _Context.SaveChanges();

            /*A*/
            _BookServices.UpdateStockAfterReserva(bookId, cantidad);

            //return GetAll();

            return _Context.Reserva.ToList();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="userId"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Reserva/Devolucion/{reservaId}")]
        public ICollection<Reserva> Devolucion(int reservaId)
        {

            Reserva res = _Context.Reserva.Where(x => x.ReservaId == reservaId).FirstOrDefault();


            res.Estado = Constants.EstadoReserva.Devuelto.ToString();
            res.FechaDevolucion = DateTime.Now;


            _Context.SaveChanges();

            /*A*/
            _BookServices.UpdateStockAfterDevolucion(res.BookId, res.Cantidad);

            //return GetAll();

            return _Context.Reserva.ToList();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Reserva/GetReservasByUserId/{userId}")]
        public ICollection<Reserva> GetReservasByUserId(int userId)
        {

            Users users = _Context.Users.Where(u => u.UsersId == userId).FirstOrDefault();
            if (users.Administrator)
            {
                return _Context.Reserva.ToList();
            }
            else
            {
                return _Context.Reserva.Where(r => r.UserId == users.UsersId).ToList();
            }
        }
    }
}
