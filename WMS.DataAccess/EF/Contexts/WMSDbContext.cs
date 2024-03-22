using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Model.Entities;

namespace WMS.DataAccess.EF.Contexts
{
    public class WMSDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS;database=WMS_DB;trusted_connection=true;");
        }

        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Rol> Roller { get; set; }

    }
}
