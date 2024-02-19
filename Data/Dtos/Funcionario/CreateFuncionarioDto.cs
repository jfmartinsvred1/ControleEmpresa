namespace ControleEmpresa.Data.Dtos.Funcionario
{
    public class CreateFuncionarioDto
    {
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int SetorId { get; set; }
    }
}
