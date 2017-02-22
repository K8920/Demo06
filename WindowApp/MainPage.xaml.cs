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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowApp
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double Value1 = double.Parse(LeveysBox.Text);
            double Value2 = double.Parse(KorkeusBox.Text);
            double Value3 = double.Parse(KarmipuuLeveysBox.Text);

            double Value; //Ikkuna pinta-ala
            double Value4; // Lasin pinta-ala

            Value = (Value1 * Value2) / 10;
            Value3 = ((Value2 * 2) + (Value1 * 2)) / 10;
            LasiPABox.Text = Value4.ToString() + "cm^2";
            Ipintaala.Text = Value.ToString() + "cm^2";
            KarmiBox.Text = Value3.ToString() + "cm";
         
        }
    }
}
