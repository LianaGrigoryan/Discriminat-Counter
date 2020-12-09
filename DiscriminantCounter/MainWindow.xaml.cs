using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DiscriminantCounter
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

        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            reset();
            if (!areTextBoxesEmpty())
            {
                double a = double.Parse(tboxA.Text);
                double b = double.Parse(tboxB.Text);
                double c = double.Parse(tboxC.Text);
                if (isNull(a))
                {
                    tboxError.Visibility = Visibility.Visible;
                }
                else
                {
                    Discriminant discriminant = new Discriminant(a, b, c);
                    discriminant.countDiscriminat();
                    layoutResult.Visibility = Visibility.Visible;
                    labelD.Content = labelD.Content?.ToString() + discriminant.D;
                    labelX1.Content = labelX1.Content?.ToString() + string.Format("{0:F1}", discriminant.X1);
                    labelX2.Content = labelX2.Content?.ToString() + string.Format("{0:F1}", discriminant.X2);
                }
            }
        }

        private void reset()
        {
            labelD.Content = "D   =   ";
            labelX1.Content = "X1   =   ";
            labelX2.Content = "X2   =   ";
            tboxError.Visibility = Visibility.Hidden;
            layoutResult.Visibility = Visibility.Hidden;
        }

        private bool areTextBoxesEmpty()
        {
            if (String.IsNullOrEmpty(tboxA.Text) ||
              String.IsNullOrEmpty(tboxB.Text) ||
              String.IsNullOrEmpty(tboxC.Text))
            {
                return true;
            }
            return false;
        }

        private bool isNull(double value)
        {
            if (value == 0) 
            {
                return true;
            }
            return false;
        }

        private void info_click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.mathsisfun.com/algebra/quadratic-equation.html");
        }
    }
}