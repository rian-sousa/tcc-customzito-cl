using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBancoLib
{
    [Table("TD_TipoVestimenta")]
    public class TD_TipoVestimenta
    {
        [Key]
        [Required]
        public int IdTipoVestimenta { get; set;}

        public string? Descricao { get; set; }
    }
}
