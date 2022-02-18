using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Reserva
    {
        public Reserva()
        {
            ReservaId = -1;
            BookId = -1;
            UserId = -1;
            Cantidad = 0;
            FechaSolicitud = Constants.DefaultDateTime;
            FechaDevolucion = Constants.DefaultDateTime;
            Estado = string.Empty;
        }

        public int ReservaId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Estado { get; set; }
    }
}