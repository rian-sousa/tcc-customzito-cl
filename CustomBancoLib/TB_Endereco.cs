using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBancoLib
{
    [Table("TB_Endereco")]
    public class TB_Endereco
    {
        [Key]
        [Required]
        public int IdEndereco { get; set; }
        public string? Quadra { get; set; }
        public string? Lote { get; set; }
        public string? numCasa { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Complemento { get; set; }
    }
}
