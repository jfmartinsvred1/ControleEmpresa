using ControleEmpresa.Data;

namespace ControleEmpresa.Filters
{
    public class FuncionarioFilter
    {
        IPontoDao _pontoDao;

        public FuncionarioFilter(IPontoDao pontoDao)
        {
            _pontoDao = pontoDao;
        }

    }
}
