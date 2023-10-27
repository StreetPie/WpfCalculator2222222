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
using SumSeriesLibrary;

namespace WpfCalculator2222222
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            Calculation calculator = new Calculation();

            double x = double.Parse(XTextBox.Text); 
            double eps = double.Parse(EpsTextBox.Text); 

            double result = calculator.CalculateSumSeries(x, eps);

            ResultListBox.Items.Add($"Результат вычисления при x = {x} и e = {eps}. Ответ: {result}");
        }
    }
}
