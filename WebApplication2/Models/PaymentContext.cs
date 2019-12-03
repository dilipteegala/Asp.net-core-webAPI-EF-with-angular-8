using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {
        }

        public DbSet<Payments> Payments { get; set; }

        public DbSet<Payments> Payment { get; set; }
        public DbSet<Emp> Emp { get; set; }
    }
    public class Payments
    {
        [Key]
        public int PaymentId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Bank Name")]
        public string BankName { get; set; }

        [Column(TypeName = "varchar(11)")]
        [DisplayName("IFSC Code")]
        public string IFSCCode { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Branch Location")]
        public string BranchLocation { get; set; }
    }
}

