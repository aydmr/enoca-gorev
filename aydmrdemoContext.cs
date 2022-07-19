using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EnocaDemo.Entities;

namespace EnocaDemo
{
    public class aydmrdemoContext:DbContext
    {
        public DbSet<Film> Film { get; set; }
        public DbSet<Gosterim> Gosterim { get; set; }
        public DbSet<Salon> Salon { get; set; }
    }
}