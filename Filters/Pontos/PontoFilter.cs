using ControleEmpresa.Data.Entity;
using ControleEmpresa.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEmpresa.Filters.Pontos
{
    public class PontoFilter
    {
        AppDbContext _db;

        public PontoFilter(AppDbContext db)
        {
            this._db = db;
        }
        public bool VerificaSeNaoBateuPontoDeEntrada(int funcId)
        {
            var ponto = RetornaPonto(funcId);
            if (ponto == null) return true;
            else return false;
        }
        public Ponto RetornaPonto(int funcId)
        {
             return _db.Pontos.FirstOrDefault(func => func.FuncionarioId == funcId && func.Saida == null);
        }
        public string RetornaHorarioMedioDeEntrada(int id)
        {
            var pontos = _db.Pontos.Where(i => i.FuncionarioId == id).ToList();
            double horas = 0;
            double minutos = 0;
            int contagem = 0;

            foreach (var ponto in pontos)
            {
                horas += ponto.Entrada.Hour;
                minutos += ponto.Entrada.Minute;
                contagem++;
            }
            horas = horas / contagem;
            minutos = minutos / contagem;

            horas = Math.Round(horas, 0);
            minutos = Math.Round(minutos, 0);

            return $"{horas}:{minutos}";
        }
        
    }
}
