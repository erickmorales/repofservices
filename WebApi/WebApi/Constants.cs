using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi
{
    public class Constants
    {
        public static DateTime DefaultDateTime = new DateTime(1900, 1, 1);
        public enum EstadoReserva
        {
            Prestado = 1,
            Devuelto

        }
    }
}