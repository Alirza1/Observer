using ObserverTask.Database;
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
    /// Interaction logic for SubscWin.xaml
    /// </summary>
    public partial class SubscWin : Window
    {
        public SubscWin()
        {
            InitializeComponent();
        }

        private void show_post_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void show_notification_btn_Click(object sender, RoutedEventArgs e)
        {
            Window n = new NotificationWin();
            n.Show();
        }
    }
}
