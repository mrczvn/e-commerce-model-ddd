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
    }
}