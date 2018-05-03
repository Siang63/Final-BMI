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

namespace NewBMI
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {   // Position
            double Value = Math.Round(HeightSlider.Value, 0);
            HeightNumber.Text = Value.ToString();
            Canvas.SetLeft(Height, (Value / 200) * 320);
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {   // Position
            double Value = Math.Round(WeightSlider.Value, 0);
            WeightNumber.Text = Value.ToString();
            Canvas.SetLeft(Weight, (Value/200)*320);

            // BMI
            double w = double.Parse(WeightNumber.Text);
            double h = double.Parse(HeightNumber.Text) / 100;
            double bmi = w/Math.Pow((h*h),1);

            // Split
            string[] parts = Math.Round(bmi, 1).ToString().Split('.');

            BMINumber1.Text = parts[0];

            if(parts.Length>1)
            {
                BMINumber2.Text = "." + parts[1];
            }
            else
            {
                BMINumber2.Text = ".0";
            }
        }
    }
}
