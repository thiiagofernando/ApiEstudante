using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiEstudantes.models
{
    [Table("estudante",Schema="public")]
    public class Estudante
    {
        [Key]
        public int estudanteid { get; set; }
        public string email { get; set; }
        public string nome { get; set; }

    }
}