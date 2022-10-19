using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for Youtuber.xaml
    /// </summary>
    public partial class Youtuber : Window
    {
        public Youtuber()
        {
            InitializeComponent();
        }

        private void add_post_btn_Click(object sender, RoutedEventArgs e)
        {
            Window addPost_win = new AddPost();
            addPost_win.Show();
        }

        private void show_sub_btn_Click(object sender, RoutedEventArgs e)
        {
            Window showSub_win = new ShowSub();
            showSub_win.Show();
        }
    }
}
