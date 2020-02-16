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

namespace WPFslider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void sldr_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblwaarde.Content = Math.Round(sldr.Value * 10);
            
            if(sldr.Value > 33)
            {
                lblwaarde.Foreground = Brushes.Yellow;
            }
            if(sldr.Value > 72)
            {
                lblwaarde.Foreground = Brushes.Orange;
            }
            if (sldr.Value > 90)
            {
                lblwaarde.Foreground = Brushes.Brown;
            }
            if (sldr.Value < 34 )
            {
       
            lblwaarde.Foreground = Brushes.Green;
                
            }







        }
    }
}
