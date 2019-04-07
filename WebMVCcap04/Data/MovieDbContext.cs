using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebMVCcap04.Models;

namespace WebMVCcap04.Data
{
    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        //La cadena de conexión se llamará MovieConnection
        public MovieDbContext() : base("MovieConnection")
        {

        }

    }
}