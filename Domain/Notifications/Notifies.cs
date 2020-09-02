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
        public string messsage { get; set; }

        [NotMapped]
        public List<Notifies> Notifications;

        public bool ValidateStringProperty(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies { messsage = "Campo Obrigátorio", PropertyName = propertyName });

                return false;
            }
            return true;
        }
    }
}