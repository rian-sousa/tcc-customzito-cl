using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBancoLib
{
    [Table("TB_Colecao")]
    public class TB_Colecao
    {
        [Key]
        [Required]
        public int IdColecao { get; set; }
        public string? Descricao { get; set; }
        public bool? Limitado { get; set; }
    }
}
