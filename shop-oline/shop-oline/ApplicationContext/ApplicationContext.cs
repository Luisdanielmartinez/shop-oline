using shop_oline.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace shop_oline.ApplicationContext
{
    public class ApplicationContext: DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Item> Items { get; set; }
        public ApplicationContext()
        {

        }
    }
}