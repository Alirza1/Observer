using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.Entities
{
    public class Post
    {
        public Post(string title, Image thumbnail)
        {
            Title = title;
            Thumbnail = thumbnail;
        }

        public string Title { get; set; }
        public Image Thumbnail { get; set; }
    }
}
