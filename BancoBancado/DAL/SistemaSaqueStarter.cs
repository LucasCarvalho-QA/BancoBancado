using BancoBancado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoBancado.DAL
{
    public class SistemaSaqueStarter : System.Data.Entity.DropCreateDatabaseIfModelChanges<SistemaSaqueDAL>
    {
        protected override void Seed(SistemaSaqueDAL context)
        {
            var cedulas = new List<CaixaEletronicoModel>
            {
               new CaixaEletronicoModel
               {
                  Cedula = 2,
                  Quantidade = 100,
               },
               new CaixaEletronicoModel
               {
                  Cedula = 5,
                  Quantidade = 100,
               },
               new CaixaEletronicoModel
               {
                  Cedula = 10,
                  Quantidade = 100,
               },
               new CaixaEletronicoModel
               {
                  Cedula = 20,
                  Quantidade = 100,
               },
               new CaixaEletronicoModel
               {
                  Cedula = 50,
                  Quantidade = 100,
               },
               new CaixaEletronicoModel
               {
                  Cedula = 100,
                  Quantidade = 100,
               },
            };

            cedulas.ForEach(s => context.CaixaEletronico.Add(s));
            context.SaveChanges();
        }
    }
}