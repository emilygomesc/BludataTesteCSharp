using System.ComponentModel.DataAnnotations;

namespace BludataAPI.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
    }
}
