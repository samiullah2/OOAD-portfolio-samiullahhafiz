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

namespace WPFpunten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (txtnaam.Text != "" && txtpunten.Text != "")
            {
                ListBoxItem lstitem = new ListBoxItem();
                lstitem.Content = txtnaam.Text + " - " + txtpunten.Text;
                lstpunten.Items.Add(lstitem);

            }

            else
                MessageBox.Show("vul uw vakjes in");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lstpunten.Items.Remove(lstpunten.SelectedItem);


        }

        private void txtfilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstpunten.Items.Clear();
        }
    }
}
