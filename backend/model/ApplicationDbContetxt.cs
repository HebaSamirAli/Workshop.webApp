using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace backend.model
{
    
    public class ApplicationDbContetxt : DbContext
    {
        public ApplicationDbContetxt(DbContextOptions<ApplicationDbContetxt> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Workshop> Workshop { get; set; }
        public DbSet<Register> Register { get; set; }



    }
}
