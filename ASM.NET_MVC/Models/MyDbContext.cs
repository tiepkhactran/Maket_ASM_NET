using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASM.NET_MVC.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MyContext")
        {

        }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Coin> Coins { get; set; }
    }
}