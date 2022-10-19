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

namespace ObserverTask.Database
{
    /// <summary>
    /// Interaction logic for NotificationWin.xaml
    /// </summary>
    public partial class NotificationWin : Window
    {
        public NotificationWin()
        {
            InitializeComponent();

            
                foreach (var no in DB.subscriber2.Notifications)
                {
                    notification_lb.Items.Add($"{no.Title} \n \t\t\tfrom {no.Youtuber.Username}\n\n");

                }
            
        }
    }
}
