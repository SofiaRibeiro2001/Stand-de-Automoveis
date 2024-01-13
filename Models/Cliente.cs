using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MvcViaturas.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Morada { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public string? Email { get; set; }
        public int Telefone { get; set; }

    }
}
