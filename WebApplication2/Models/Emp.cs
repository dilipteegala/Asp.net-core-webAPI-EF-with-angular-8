using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Emp
    {
        [Key]
        public int PaymentId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Emp Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Bank Name")]
        public string BankName { get; set; }
    }
}