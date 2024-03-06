using ControleEmpresa.Data.Entity;
using ControleEmpresa.Models;

namespace ControleEmpresa.Filters
{
    public class EstatisticaService
    {
        AppDbContext _appDbContext;
        public int FuncionarioId { get; set; }
        public EstatisticaService(int funcionarioId, AppDbContext appDbContext)
        {

            FuncionarioId = funcionarioId;
            _appDbContext = appDbContext;
        }

        public void FazEstatistica() 
        {
            //var pontos = _appDbContext.Pontos.Where(id=>id.FuncionarioId==FuncionarioId).ToList();
            //var funcionario = _appDbContext.Funcionarios.FirstOrDefault(func=>func.FuncionarioId==FuncionarioId);
            //if (funcionario != null)
            //{
            //    var tempoNaEmpresa=DateTime.Now.Subtract(funcionario.DataDeContratacao);

            //    var diasDeSemana = 0;

            //    var hoje = DateTime.Now.Date;


            //    for(DateTime dataIndice = funcionario.DataDeContratacao; dataIndice <= hoje; dataIndice.AddDays(1))
            //    {
       
            //        int[] diasDaSemana = new int[5] { 1, 2, 3, 4, 5 };
            //        var ponto = pontos.FirstOrDefault(pt=>pt.Dia==dataIndice);
            //        if (diasDaSemana.Contains(ponto.DiaDaSemana))
            //        {
            //            diasDeSemana++;
            //        }
                    
            //    }

            //    while (dataIndice != hoje)
            //    {
            //        var ponto = pontos.FirstOrDefault(pt => pt.Dia)
            //    }


            //    Estatistica estatistica = new Estatistica(tempoNaEmpresa,);

            //}
        }

    }
}
