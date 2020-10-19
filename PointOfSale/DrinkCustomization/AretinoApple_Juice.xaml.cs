using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
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

/*
 * Author: Trevor Prondzinski
 * Class name: AretinoApple_Juce.xaml.cs
 * Purpose: To allow ordering and customization of the item Aretino Apple Juice
 */
namespace PointOfSale.DrinkCustomization
{
    /// <summary>
    /// Interaction logic for AretinoApple_Juice.xaml
    /// </summary>
    public partial class AretinoApple_Juice : UserControl
    {
        MainWindow ancestor;
        /// <summary>
        /// initialize arentino apple juice customization
        /// </summary>
        public AretinoApple_Juice(MainWindow ancestor)
        {
         
            InitializeComponent();
            this.ancestor = ancestor;
        }
        //public event EventHandler<CustomizationSelector> CurrentSelector;
        MainWindow window = (MainWindow)Application.Current.MainWindow;
        /// <summary>
        /// navigates to the welcome page
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void BacktoBegin(object sender, RoutedEventArgs e)
        {
            
            //this.NavigationService.Navigate(new WelcomePage());
            window.DisplayCurrentOrder();
        }
    }
}
