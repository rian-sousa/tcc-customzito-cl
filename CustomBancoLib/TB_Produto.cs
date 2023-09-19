using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBancoLib
{
    [Table("TB_Produto")]
    public class TB_Produto
    {
        [Key] 
        [Required]
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public float? Preco { get; set; }

        [ForeignKey("IdTipoVestimenta")]
        [Required]
        public int IdTipoVestimenta { get; set; }

        [ForeignKey("IdColecao")]
        [Required]
        public int IdColecao { get; set; }

        public decimal? Avaliacao { get; set; }

        public int? qtd { get; set; }
    }
}
