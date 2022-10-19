using ObserverTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.Database
{
    static public class DB
    {
        static public List<Post> posts = new List<Post>();
        static public List<Notification> notifications = new List<Notification>();
        static public List<Subscriber> subscribers=new List<Subscriber>();
        static public Admin admin= new Admin("aallirza",posts);

        static public Subscriber subscriber = new Subscriber("elvin1234",notifications);
        static public Subscriber subscriber2 = new Subscriber("nurlan1234",notifications);
        static public Subscriber subscriber3 = new Subscriber("arif1234",notifications);

    }
}
