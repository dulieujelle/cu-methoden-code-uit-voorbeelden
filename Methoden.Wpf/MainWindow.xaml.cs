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

namespace Methoden.Wpf
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
        private void BtnToonLand_Click(object sender, RoutedEventArgs e)
        {
            string teTonenLand = "Frankrijk";
            ToonLand(teTonenLand);
        }
        void ToonLand(string land)
        {
            MessageBox.Show("Het land is " + land);
        }

    }
}
