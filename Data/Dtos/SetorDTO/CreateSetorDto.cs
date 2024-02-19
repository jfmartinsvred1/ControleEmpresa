using System.ComponentModel.DataAnnotations;

namespace ControleEmpresa.Data.Dtos.SetorDTO
{
    public class CreateSetorDto
    {
        [MaxLength(20)]
        public string? Nome { get; set; }
    }
}
