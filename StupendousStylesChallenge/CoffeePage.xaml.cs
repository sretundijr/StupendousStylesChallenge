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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StupendousStylesChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CoffeePage : Page
    {

        private string _roast;
        private string _cream;
        private string _sweetener;

        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _cream = selected.Text;
            displayResults();
        }

        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sweetener = selected.Text;
            displayResults();
        }

        private void Roast_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roast = selected.Text;
            displayResults();
        }

        private void displayResults()
        {
            if(_roast == "None" || String.IsNullOrEmpty(_roast))
            {
                orderTextBlock.Text = "None";
                return;
            }

            orderTextBlock.Text = _roast;

            if(_cream != "None" && !String.IsNullOrEmpty(_cream))
            {
                orderTextBlock.Text += " + " + _cream;
            }

            if (_sweetener != "None" && !String.IsNullOrEmpty(_sweetener))
            {
                orderTextBlock.Text += " + " +_sweetener;
            }
        }
    }
}
