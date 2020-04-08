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
    /// Interaction logic for choice.xaml
    /// </summary>
    public partial class choice : UserControl
    {
        public choice()
        {
            InitializeComponent();
        }

        private void btnGeld_Click(object sender, RoutedEventArgs e)
        {
            geldOpnemen go = new geldOpnemen();
            gridInhoud.Children.Clear();
            gridInhoud.Children.Add(go);
        }

        private void btnSaldo_Click(object sender, RoutedEventArgs e)
        {
            saldoChecken go = new saldoChecken();
            gridInhoud.Children.Clear();
            gridInhoud.Children.Add(go);
        }
    }
}
