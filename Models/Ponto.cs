using System.ComponentModel.DataAnnotations;

namespace ControleEmpresa.Models
{
    public class Ponto
    {
        [Key]
        public int PontoId { get; set; }
        public DateTime Dia { get; set; } = DateTime.Today;
        public TimeOnly Entrada { get; set; }
        public TimeOnly Saida { get; set; }
        public int FuncId { get; set; }
        public virtual Funcionario? Funcionario { get; set; }
    }
}
