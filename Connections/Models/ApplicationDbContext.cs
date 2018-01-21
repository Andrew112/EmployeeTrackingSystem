using CodeFirstModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class ApplicationDbContext : DbContext
    {


        
        
        public DbSet<Employee> Employees { get; set; }
      
    }
}