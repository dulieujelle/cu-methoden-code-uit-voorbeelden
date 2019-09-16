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

namespace BerekenSom.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int som;
        public MainWindow()
        {
            InitializeComponent();
        }
        int BerekenSom(int getalLinks, int getalRechts)
        {
            return getalLinks + getalRechts;
        }
        int BerekenSom(string getalLinks, string getalRechts)
        {
            int links = int.Parse(getalLinks);
            int rechts = int.Parse(getalRechts);
            return BerekenSom(links, rechts);
        }


        private void BtnBerekenSom_Click(object sender, RoutedEventArgs e)
        {
            //int links = int.Parse(txtGetalLinks.Text);
            //int rechts = int.Parse(txtGetalRechts.Text);

            string links = txtGetalLinks.Text;
            string rechts = txtGetalRechts.Text;

            som = BerekenSom(links, rechts);
            MessageBox.Show("De som van " + links + " en " + rechts + " is " + som, "Som berekenen");
        }
        void ScopeText()
        {
            MessageBox.Show("De som was: " + som);
        }

    }
}
