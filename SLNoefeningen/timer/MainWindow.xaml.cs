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
using System.Windows.Threading;

namespace timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer1 = new DispatcherTimer();
        private int count = 0;

        public MainWindow()
        {

            InitializeComponent();
            lblCount.Content = count;
            timer1.Interval = TimeSpan.FromMilliseconds(10);
            timer1.Tick += timer_Tick; // voeg methode toe aan timer


        }
        private void timer_Tick(object sender, EventArgs e)
        {
            count++;
            lblCount.Content = count;
            if (count > 59)
            {
                lblCount1.Content = count / 60;
                lblCount.Content = count % 60;
            }
        }




        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            timer1.Start(); // start de timer
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            timer1.Stop();
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            count = 0;
            lblCount.Content = 0;
            lblCount1.Content = 0;
        }
    }
}
