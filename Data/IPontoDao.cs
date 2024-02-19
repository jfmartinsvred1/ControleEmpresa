using ControleEmpresa.Data.Dtos.PontoDTO;

namespace ControleEmpresa.Data
{
    public interface IPontoDao
    {
        void Entrada(CreatePontoDto ponto);
        void Saida(int funcId);
    }
}
