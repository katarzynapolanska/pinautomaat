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
    /// Interaction logic for geldOpnemen.xaml
    /// </summary>
    public partial class geldOpnemen : UserControl
    {
        int saldo = 1000;
        public geldOpnemen()
        {
            InitializeComponent();
            txtSaldo.Text = saldo.ToString() + " €";
        }

        private void btnTen_Click(object sender, RoutedEventArgs e)
        {
            int ten = 10;
            int opnemen = saldo - ten;
            txtSaldo.Text = opnemen.ToString() + " €";
            txtKeuze.Text = ten.ToString() + " €";
        }

        private void btnTwenty_Click(object sender, RoutedEventArgs e)
        {
            int twenty = 20;
            int opnemen = saldo - twenty;
            txtSaldo.Text = opnemen.ToString() + " €";
            txtKeuze.Text = twenty.ToString() + " €";
        }

        private void btnFifty_Click(object sender, RoutedEventArgs e)
        {
            int fifty = 50;
            int opnemen = saldo - fifty;
            txtSaldo.Text = opnemen.ToString() + " €";
            txtKeuze.Text = fifty.ToString() + " €";
        }

        private void btnHundred_Click(object sender, RoutedEventArgs e)
        {
            int hundred = 100;
            int opnemen = saldo - hundred;
            txtSaldo.Text = opnemen.ToString() + " €";
            txtKeuze.Text = hundred.ToString() + " €";
        }

        private void btnHundredFifty_Click(object sender, RoutedEventArgs e)
        {
            int hFifty = 150;
            int opnemen = saldo - hFifty;
            txtSaldo.Text = opnemen.ToString() + " €";
            txtKeuze.Text = hFifty.ToString() + " €";
        }

        private void btnTwoHundred_Click(object sender, RoutedEventArgs e)
        {
            int tHundred = 200;
            int opnemen = saldo - tHundred;
            txtSaldo.Text = opnemen.ToString() + " €";
            txtKeuze.Text = tHundred.ToString() + " €";
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            end go = new end();
            gInhoud.Children.Clear();
            gInhoud.Children.Add(go);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            choice go = new choice();
            gInhoud.Children.Clear();
            gInhoud.Children.Add(go);
        }
    }
}
