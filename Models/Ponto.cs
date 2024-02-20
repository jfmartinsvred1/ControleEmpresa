using System.ComponentModel.DataAnnotations;

namespace ControleEmpresa.Models
{
    public class Ponto
    {
        [Key]
        public int PontoId { get; set; }
        public DateTime Dia { get; set; } = DateTime.Today;
        public DateTime Entrada { get; set; } = DateTime.Now;
        public DateTime? Saida { get; set; } = null;
        public int FuncionarioId { get; set; }
        public virtual Funcionario? Funcionario { get; set; }
    }
}
