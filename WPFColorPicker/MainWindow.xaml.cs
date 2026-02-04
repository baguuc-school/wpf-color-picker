using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFColorPicker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            byte rValue = ((byte)this.RValueSlider.Value);
            byte gValue = ((byte)this.GValueSlider.Value);
            byte bValue = ((byte)this.BValueSlider.Value);
            Color newColor = Color.FromRgb(rValue, gValue, bValue);

            this.RValueLabel.Content = rValue.ToString();
            this.GValueLabel.Content = gValue.ToString();
            this.BValueLabel.Content = bValue.ToString();

            this.TotalValueLabel.Content = $"{rValue.ToString()}, {gValue.ToString()}, {bValue.ToString()}";
            this.TotalValueLabel.Background = new SolidColorBrush(newColor);
            this.ColorShowcaseBox.Fill = new SolidColorBrush(newColor);
        }

        private void RValueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(RValueLabel != null && GValueLabel != null && BValueLabel != null)
            {
                RValueLabel.Content = ((int)RValueSlider.Value).ToString();

                byte rValue = ((byte)this.RValueSlider.Value);
                byte gValue = ((byte)this.GValueSlider.Value);
                byte bValue = ((byte)this.BValueSlider.Value);
                Color newColor = Color.FromRgb(rValue, gValue, bValue);
                this.ColorShowcaseBox.Fill = new SolidColorBrush(newColor);
            }
        }

        private void GValueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (RValueLabel != null && GValueLabel != null && BValueLabel != null)
            {
                GValueLabel.Content = ((int)GValueSlider.Value).ToString();

                byte rValue = ((byte)this.RValueSlider.Value);
                byte gValue = ((byte)this.GValueSlider.Value);
                byte bValue = ((byte)this.BValueSlider.Value);
                Color newColor = Color.FromRgb(rValue, gValue, bValue);
                this.ColorShowcaseBox.Fill = new SolidColorBrush(newColor);
            }
        }

        private void BValueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (RValueLabel != null && GValueLabel != null && BValueLabel != null)
            {
                BValueLabel.Content = ((int)BValueSlider.Value).ToString();

                byte rValue = ((byte)this.RValueSlider.Value);
                byte gValue = ((byte)this.GValueSlider.Value);
                byte bValue = ((byte)this.BValueSlider.Value);
                Color newColor = Color.FromRgb(rValue, gValue, bValue);
                this.ColorShowcaseBox.Fill = new SolidColorBrush(newColor);
            }
        }
    }
}