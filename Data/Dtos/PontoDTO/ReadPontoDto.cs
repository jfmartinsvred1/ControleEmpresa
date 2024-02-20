namespace ControleEmpresa.Data.Dtos.PontoDTO
{
    public class ReadPontoDto
    {
        public DateTime Dia { get; set; } 
        public DateTime Entrada { get; set; } 
        public DateTime Saida { get; set; }
        public int FuncionarioId { get; set; }
    }
}
