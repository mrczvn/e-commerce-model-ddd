using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        [NotMapped]
        public string PropertyName { get; set; }

        [NotMapped]
        public int messsage { get; set; }

        [NotMapped]
        public List<Notifies> Notifications;
    }
}