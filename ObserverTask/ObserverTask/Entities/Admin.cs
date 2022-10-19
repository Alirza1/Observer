using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.Entities
{
    public class Admin:User
    {
        public Admin(string username,List<Post> posts) : base(username)
        {
            Posts = posts;
        }

        public List<Post> Posts { get; set; }
    }
}
