using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBancoLib
{
    [Table("TB_Carrinho")]
    public class TB_Carrinho
    {
        [Key]
        [Required]
        public int IdCarrinho { get; set; }
        public int? IdPerfil { get; set; }
        public float? ValorTotal { get; set; }
        public string? items { get; set; }
    }
}
