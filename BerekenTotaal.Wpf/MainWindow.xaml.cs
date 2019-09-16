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

namespace BerekenTotaal.Wpf
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

        private void BtnBereken_Click(object sender, RoutedEventArgs e)
        {
            float tarief;
            decimal prijsExcl;
            tarief = float.Parse(txtTarief.Text);
            prijsExcl = decimal.Parse(txtExcl.Text);
            tbkBerekening.Text = ToonBtwBerekening(tarief, prijsExcl);
        }
        decimal BtwBedrag(float tarief, decimal prijsExcl)
        {
            decimal btwBedrag;
            btwBedrag = prijsExcl * (decimal)tarief / 100;
            return btwBedrag;
        }
        string ToonBtwBerekening(float tarief, decimal prijsExcl)
        {
            string samenvatting = "";
            decimal btwBedrag;
            decimal prijsIncl;
            btwBedrag = BtwBedrag(tarief, prijsExcl);
            prijsIncl = prijsExcl + btwBedrag;
            samenvatting = "Berekening BTW\n\n" +
                $"BTW excl.\t€ {prijsExcl.ToString("0.00")}\n" +
                $"BTW tarief\t{tarief} %\n" +
                $"BTW bedrag\t€ {btwBedrag.ToString("0.00")}\n" +
                $"BTW incl\t\t€ {prijsIncl.ToString("0.00")}\n";
            return samenvatting;
        }

    }
}
