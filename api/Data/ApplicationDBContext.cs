using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
       public ApplicationDBContext(DbContextOptions DbContextOptions)
       : base(DbContextOptions)
       {
        
       }
       public DbSet<Stock> Stock {get;set;}
       public DbSet<Comment> Comments {get;set;}
    }
}