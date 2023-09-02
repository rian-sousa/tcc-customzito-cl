using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBancoLib
{
    [Table("TB_Perfil")]
    public class TB_Perfil
    {
        [Key]
        [Required]
        public int IdPerfil { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        [Required]
        public string DataNascimento { get; set; }

        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }

        [ForeignKey("IdEndereco")]
        [Required]
        public int IdEndereco { get; set; }
        [ForeignKey("IdTipoUsuario")]
        [Required]
        public int IdTipoUsuario { get; set; }
    }
}
