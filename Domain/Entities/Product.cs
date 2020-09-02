using Domain.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Product")]
    public class Product : Notifies
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PRD_NOME")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("PRD_VALO")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Column("PRD_ESTADO")]
        [Display(Name = "Estado")]
        public bool Status { get; set; }
    }
}