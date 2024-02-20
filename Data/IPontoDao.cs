using ControleEmpresa.Data.Dtos.PontoDTO;
using ControleEmpresa.Models;

namespace ControleEmpresa.Data
{
    public interface IPontoDao
    {
        void Entrada(CreatePontoDto ponto);
        void Saida(int funcId);
        IEnumerable<ReadPontoDto> ReadPonto();
    }
}
