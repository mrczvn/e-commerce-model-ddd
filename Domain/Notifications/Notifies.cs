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
        public string message { get; set; }

        [NotMapped]
        public List<Notifies> Notifications;

        public bool ValidateStringProperty(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies { message = "Campo Obrigátorio", PropertyName = propertyName });

                return false;
            }
            return true;
        }

        public bool ValidateIntProperty(int value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies { message = "Valor deve ser maior que 0", PropertyName = propertyName });

                return false;
            }
            return true;
        }

        public bool ValidateDecimalProperty(decimal value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies { message = "Valor deve ser maior que 0", PropertyName = propertyName });

                return false;
            }
            return true;
        }
    }
}