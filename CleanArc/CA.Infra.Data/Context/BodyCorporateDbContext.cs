using CleanArc.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Infra.Data.Context
{
    public class BodyCorporateDbContext : DbContext
    {
        public BodyCorporateDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BodyCorporate> BodyCorporates { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
