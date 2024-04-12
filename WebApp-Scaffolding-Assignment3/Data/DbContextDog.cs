using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp_Scaffolding_Assignment3.Models;

    public class DbContextDog : DbContext
    {
        public DbContextDog (DbContextOptions<DbContextDog> options)
            : base(options)
        {
        }

        public DbSet<WebApp_Scaffolding_Assignment3.Models.Dog> Dog { get; set; } = default!;
    }
