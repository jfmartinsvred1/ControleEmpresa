using System.ComponentModel.DataAnnotations;

namespace ControleEmpresa.Data.Dtos.Setor
{
    public class CreateSetorDto
    {
        [MaxLength(20)]
        public string? Nome { get; set; }
    }
}
