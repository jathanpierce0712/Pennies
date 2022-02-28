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

namespace Pennies_app
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

        public int num_ofPennies { get; set; }

        private void Penny_btn_Click(object sender, RoutedEventArgs e)
        {
            int pen = 0;
            Int32.TryParse(num_ofPens.Text, out pen);

            int dollar = pen / 100;
            Num_dollars.Text = $"{dollar}";

            int quarter = pen / 25;
            Num_quarters.Text = $"{quarter}";
            int dimes = pen / 10;
            Num_dimes.Text = $"{dimes}";
            int nickles = pen / 5;
            Num_nickles.Text = $"{nickles}";
            Num_pennies.Text = $"{pen}";
        }

        private void Clear_btn_Click(object sender, RoutedEventArgs e)
        {
            Num_dollars.Text = "0";
            Num_quarters.Text = "0";
            Num_dimes.Text = "0";
            Num_nickles.Text = "0";
            Num_pennies.Text = "0";
        }
    }
}