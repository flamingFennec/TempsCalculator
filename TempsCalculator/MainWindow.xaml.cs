using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace TempsCalculator
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

        private void tempBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextClicked(object sender, TextChangedEventArgs e)
        {
            
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            string temps = tempBox.Text;
            Double toF;
            toF = (double.Parse(temps) * 1.8000) + 32.00;
        }

        private void FOutput_TextChanged(object sender, TextChangedEventArgs e, ref double toF)
        {
            FOutput.Text = TextDecoration().toF;
        }
    }
}

