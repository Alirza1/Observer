using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.Entities
{
    public class Notification
    {
        public Notification(Admin youtuber, string title)
        {
            Youtuber = youtuber;
            Title = title;
        }

        public Admin Youtuber { get; set; }
        public string Title { get; set; }
    }
}
