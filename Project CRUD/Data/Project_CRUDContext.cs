using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_CRUD.Models;

namespace Project_CRUD.Data
{
    public class Project_CRUDContext : DbContext
    {
        public Project_CRUDContext (DbContextOptions<Project_CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Project_CRUD.Models.Car> Car { get; set; } = default!;
    }
}
