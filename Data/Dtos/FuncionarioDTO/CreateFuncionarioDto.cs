namespace ControleEmpresa.Data.Dtos.FuncionarioDTO
{
    public class CreateFuncionarioDto
    {
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataDeContratacao { get; set; }
        public int SetorId { get; set; }
    }
}
