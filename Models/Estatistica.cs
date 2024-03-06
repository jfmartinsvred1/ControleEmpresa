namespace ControleEmpresa.Models
{
    public class Estatistica
    {
        public Estatistica(TimeSpan tempoNaEmpresa, string frequencia)
        {
            TempoNaEmpresa = tempoNaEmpresa;
            Frequencia = frequencia;
        }
        public Estatistica()
        {
            
        }

        public TimeSpan TempoNaEmpresa { get; set; }
        public string Frequencia { get; set; }

        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        


    }
}
