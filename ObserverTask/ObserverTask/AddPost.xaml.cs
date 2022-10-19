using Microsoft.Win32;
using ObserverTask.Database;
using ObserverTask.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ObserverTask
{
    /// <summary>
    /// Interaction logic for AddPost.xaml
    /// </summary>
    public partial class AddPost : Window
    {
       
        public AddPost()
        {
            InitializeComponent();
        }
        public string FileName { get; set; }

        private Bitmap OriginalImage;

        private static BitmapImage BitmapToSource(Bitmap src)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            src.Save(ms, ImageFormat.Jpeg);

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }

        private void load_thumbnail_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true };
            bool? response = openFileDialog.ShowDialog();
            if (response == true)
            {
                string[] files = openFileDialog.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFullPath(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);
                    BitmapImage logo = new BitmapImage();
                    logo.BeginInit();
                    logo.UriSource = new Uri(filename);
                    logo.EndInit();
                    OriginalImage = new Bitmap(filename);
                    imagebox.Source = BitmapToSource(new Bitmap(OriginalImage));

                    var path = filename.Split('\\');
                    FileName = path[path.Length - 1];
                }
            }
        }

        private void post_btn_Click(object sender, RoutedEventArgs e)
        {
            Post post = new Post(title_txtb.Text, OriginalImage);
            DB.admin.Posts.Add(post);
            foreach (var sub in DB.subscribers)
            {
                sub.Notifications.Add(new Notification(DB.admin, $"{DB.admin.Username} just posted '{title_txtb.Text}'"));
            }
        }
    }
}
