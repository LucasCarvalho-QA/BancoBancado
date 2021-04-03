using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BancoBancado.Models
{
    [Table("CaixaEletronico")]
    public class CaixaEletronicoModel
    {
        [Key]
        public int id { get; set; }
        public int Cedula { get; set; }
        public int Quantidade { get; set; }
    }
}