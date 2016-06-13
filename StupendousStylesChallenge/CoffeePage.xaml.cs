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
        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void noneButton_Click(object sender, RoutedEventArgs e)
        {
            orderTextBlock.Text = string.Empty;
            roastFlyoutButton.Hide();
        }

        private void darkButton_Click(object sender, RoutedEventArgs e)
        {
            orderTextBlock.Text = "Dark ";
            roastFlyoutButton.Hide();
        }

        private void mediumButton_Click(object sender, RoutedEventArgs e)
        {
            orderTextBlock.Text = "Medium ";
            roastFlyoutButton.Hide();
        }

        private void noSweetenerButton_Click(object sender, RoutedEventArgs e)
        {
            orderTextBlock.Text += " +No sweetener ";
            sweetenerFlyoutButton.Hide();
        }

        private void sugarButton_Click(object sender, RoutedEventArgs e)
        {
            if(orderTextBlock.Text != string.Empty)
            {
                orderTextBlock.Text += " +Sugar ";
                sweetenerFlyoutButton.Hide();
            }
            else
            {
                sweetenerFlyoutButton.Hide();
            }
        }

        private void noCreamButton_Click(object sender, RoutedEventArgs e)
        {
            orderTextBlock.Text += " +No cream";
            creamFlyoutButton.Hide();
        }

        private void twoPercentButton_Click(object sender, RoutedEventArgs e)
        {
            if (orderTextBlock.Text != string.Empty)
            {
                orderTextBlock.Text += " +2% Milk";
                creamFlyoutButton.Hide();
            }
            else
            {
                creamFlyoutButton.Hide();
            }
        }

        private void wholeButton_Click(object sender, RoutedEventArgs e)
        {
            if (orderTextBlock.Text != string.Empty)
            {
                orderTextBlock.Text += " +Whole Milk";
                creamFlyoutButton.Hide();
            }
            else
            {
                creamFlyoutButton.Hide();
            }
        }
    }
}
