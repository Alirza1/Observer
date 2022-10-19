using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.Entities
{
    public class Subscriber:User
    {
        public Subscriber(string username, List<Notification> notifications) : base(username)
        {
            Notifications = notifications;
        }

        public List<Notification> Notifications { get; set; }
    }
}
