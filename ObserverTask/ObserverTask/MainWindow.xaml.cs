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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ObserverTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DB.subscribers.Add(DB.subscriber);
            DB.subscribers.Add(DB.subscriber2);
            DB.subscribers.Add(DB.subscriber3);
        }

        private void youtuber_btn_Click(object sender, RoutedEventArgs e)
        {
            Window youtuber_win = new Youtuber();
            youtuber_win.Show();
        }

        private void subscriber_btn_Click(object sender, RoutedEventArgs e)
        {
            Window subsc_win = new SubscWin();
            subsc_win.Show();
        }
    }
}
