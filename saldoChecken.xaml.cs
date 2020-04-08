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

namespace OpdrachtPinautomaat
{
    /// <summary>
    /// Interaction logic for saldoChecken.xaml
    /// </summary>
    public partial class saldoChecken : UserControl
    {
        int saldo = 1000;
        public saldoChecken()
        {
            InitializeComponent();
            txtSaldoChecken.Text = saldo.ToString() + " €";

        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            end go = new end();
            gInhoud.Children.Clear();
            gInhoud.Children.Add(go);
        }

        private void btnBack_Click_1(object sender, RoutedEventArgs e)
        {
            choice go = new choice();
            gInhoud.Children.Clear();
            gInhoud.Children.Add(go);
        }
    }
}
