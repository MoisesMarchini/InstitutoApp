using InstitutoApp.Models;
using InstitutoApp.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Client> Clientes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = '"+ Settings.dbPath + "'");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
