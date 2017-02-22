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

namespace Euroconverter
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

        private void Convertbutton_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(EuroBox.Text);
            double value2 = double.Parse(MarkkaBox.Text);
            value2 = value * 6;
            EuroBox.Text = value.ToString("0.00");
            MarkkaBox.Text = value2.ToString("0.00");
        }
      private void Convertbutton2_Click(object sender, RoutedEventArgs e)
      {
          double value = double.Parse(EuroBox.Text);
          double value2 = double.Parse(MarkkaBox.Text);
          value = value2 / 6;
          MarkkaBox.Text = value2.ToString("0.00");
          EuroBox.Text = value.ToString("0.00");
      }
    }
}
