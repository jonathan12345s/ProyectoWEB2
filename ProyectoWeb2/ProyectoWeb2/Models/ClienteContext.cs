using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoWeb2.Models
{
    public class ClienteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ClienteContext() : base("name=ClienteContext")
        {
        }

        public System.Data.Entity.DbSet<ProyectoWeb2.Controllers.Cliente> Clientes { get; set; }
    }
}
