using System.ComponentModel.DataAnnotations;

namespace ControleEmpresa.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataDeContratacao { get; set; }
        public int SetorId { get; set; }
        public Setor? Setor { get; set; }
        public virtual ICollection<Ponto> Pontos { get; set; }
    }
}
