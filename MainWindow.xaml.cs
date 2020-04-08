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
            byte one = 1;
            txtPin.Password += one.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            byte two = 2;
            txtPin.Password += two.ToString();
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            byte three = 3;
            txtPin.Password += three.ToString();
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            byte four = 4;
            txtPin.Password += four.ToString();
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            byte five = 5;
            txtPin.Password += five.ToString();
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            byte six = 6;
            txtPin.Password += six.ToString(); 
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            byte seven = 7;
            txtPin.Password += seven.ToString();
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            byte eight = 8;
            txtPin.Password += eight.ToString();
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            byte nine = 9;
            txtPin.Password = nine.ToString();
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            byte zero = 0;
            txtPin.Password += zero.ToString();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if(txtPin.Password == "1234")
            {
                choice go = new choice();
                gInhoud.Children.Clear();
                gInhoud.Children.Add(go);
            }
        }
    }
}
