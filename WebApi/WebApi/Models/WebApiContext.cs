using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApi.Models
{
    public class WebApiContext: DbContext
    {
        public WebApiContext()
            : base("cnn")
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Reserva> Reserva { get; set; }

    }

}