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

namespace ParamArray.Wpf
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
        private void ToonBerichten(params string[] berichten)
        {
            lstBerichten.Items.Clear();
            lblAantal.Content = "Aantal berichten: " + berichten.Length;
            foreach (string bericht in berichten)
            {
                lstBerichten.Items.Add(bericht);
            }
        }

        private void BtnToonBerichten_Click(object sender, RoutedEventArgs e)
        {
            ToonBerichten(
        "C# is leuk",
        "Soep is lekker",
        "Sneeuw is koud",
        "Binair begint met de letter b");

        }
    }
}
