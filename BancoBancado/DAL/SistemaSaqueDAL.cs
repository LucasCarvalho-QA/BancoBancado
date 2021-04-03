using BancoBancado.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BancoBancado.DAL
{
    public class SistemaSaqueDAL : DbContext
    {
        public SistemaSaqueDAL() : base(@"Server=LEKTOP\SQLEXPRESS; Database=SistemaSaque; User ID=aspnet; Password=aspnet; Trusted_Connection=False;")
        {
        }

        public DbSet<CaixaEletronicoModel> CaixaEletronico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}