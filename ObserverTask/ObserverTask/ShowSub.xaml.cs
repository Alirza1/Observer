using ObserverTask.Database;
using ObserverTask.Entities;
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
    /// Interaction logic for ShowSub.xaml
    /// </summary>
    public partial class ShowSub : Window
    {
        public ShowSub()
        {
            InitializeComponent();


            foreach (var subs in DB.subscribers)
            {
                var username = subs.Username;
                Sub_lb.Items.Add(username);
            }
        }
    }
}
