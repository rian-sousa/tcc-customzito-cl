using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBancoLib
{
    [Table("TD_TipoUsuario")]
    public class TD_TipoUsuario
    {
        [Key]
        [Required]
        public int IdTipoUsuario { get; set; }
        public string? Descricao { get; set;}
        public int? CodUsuario { get; set;}
    }
}
