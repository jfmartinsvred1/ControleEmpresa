using System.ComponentModel.DataAnnotations;

namespace ControleEmpresa.Models
{
    public class Ponto
    {
        [Key]
        public int PontoId { get; set; }
        public DateTime Dia { get; set; } = DateTime.Today;
        public DayOfWeek DiaDaSemana { get; set; } = DateTime.Now.DayOfWeek;
        public TimeSpan Entrada { get; set; } = DateTime.Now.TimeOfDay;
        public TimeSpan? Saida { get; set; } = null;
        public int FuncionarioId { get; set; }
        public virtual Funcionario? Funcionario { get; set; }
    }
}
