using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
        }

        [NotMapped]
        public string PropertyName { get; set; }
    }
}