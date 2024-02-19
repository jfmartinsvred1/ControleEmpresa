using ControleEmpresa.Data.Dtos.Ponto;

namespace ControleEmpresa.Data
{
    public interface IPontoDao
    {
        void Entrada(CreatePontoDto ponto);
        void Saida(int funcId);
    }
}
