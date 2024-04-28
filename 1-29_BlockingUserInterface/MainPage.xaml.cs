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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _1_29_BlockingUserInterface
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private double computeAverages(long noOfValues)
        {
            double total = 0;
            Random rand = new Random();

            for (long values = 0; values < noOfValues; values++)
            {
                total = total + rand.NextDouble();
            }

            return total / noOfValues;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            long noOfValues = long.Parse(NumberOfValuesTextBox.Text);
            ResultTextBlock.Text = "Result: " + computeAverages(noOfValues);
        }
    }
}
