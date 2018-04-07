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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Content;
        }

        private void button_14_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Content.ToString();
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Content = value + "" + operation;
        }

        private void button_16_Click(object sender, RoutedEventArgs e)
        {
            equation.Content = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Convert.ToDouble(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Convert.ToDouble(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Convert.ToDouble(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Convert.ToDouble(result.Text)).ToString();
                    break;
                default: break;
            }//end switch
        }

        private void button_15_Click(object sender, RoutedEventArgs e)
        {
            result.Text="0";
            value = 0;
        }
    }
}
