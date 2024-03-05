using System.ComponentModel.DataAnnotations;

namespace ControleEmpresa.Models
{
    public class Setor
    {
        [Key]
        public int SetorId { get; set; }
        public string? Nome { get; set; }
        [MaxLength(7)]
        public string Cor { get; set; }
        public virtual ICollection<Funcionario>? Funcionarios { get; set; }
    }
}
 