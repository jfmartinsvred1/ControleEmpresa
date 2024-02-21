namespace ControleEmpresa.Data.Dtos.PontoDTO
{
    public class ReadPontoDto
    {
        public DateTime Dia { get; set; }
        public DayOfWeek DiaDaSemana { get; set; }
        public TimeSpan Entrada { get; set; } 
        public TimeSpan Saida { get; set; }
        public int FuncionarioId { get; set; }
    }
}
