using BludataAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace BludataAPI.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        public UF UF { get; set; }

        [MaxLength(14, ErrorMessage = "CNPJ inválido. Confira as informações")]
        [MinLength(14, ErrorMessage = "CNPJ inválido. Confira as informações")]
        public string CNPJ { get; set; }
    }
}
