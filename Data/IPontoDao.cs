using ControleEmpresa.Data.Dtos.PontoDTO;

namespace ControleEmpresa.Data
{
    public interface IPontoDao
    {
        void Entrada(CreatePontoDto ponto);
        void Saida(int funcId);
        IEnumerable<ReadPontoDto> LerTodosPontos();
        IEnumerable<ReadPontoDto> LerPontosDeUmFuncPorId(int id);
    }
}
