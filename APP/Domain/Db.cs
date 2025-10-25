using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Domain
{
    public class Db : DbContext
    {
        public DbSet<Student> Students { get; set; }


        public Db(DbContextOptions options) : base(options)
        {

        }
    }
}
