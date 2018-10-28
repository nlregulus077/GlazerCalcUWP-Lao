using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalcUWP_Lao
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
           
        }

        

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = widthText.Text;
            width = double.Parse(widthString);

            heightString = heightText.Text;
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            woodLengthView.Text = woodLength + " feet";
            glassAreaView.Text = glassArea + " square meters";

            dateBlock.Text = "Order entered on " + DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void widthText_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            var keyValue = widthText.Text;
            double value;
            bool success = double.TryParse(keyValue, out value);

            if (success)
            {
                widthText.Text = keyValue;
            }

            else
            {
                widthText.Text = "";
            }
        }

        private void heightText_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            var keyValue = heightText.Text;
            double value;
            bool success = double.TryParse(keyValue, out value);

            if (success)
            {
                heightText.Text = keyValue;
            }

            else
            {
                heightText.Text = "";
            }
        }

        private void quantitySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            var slider = sender as Slider;
            quantityBox.Text = slider.Value.ToString();
        }
    }
}
