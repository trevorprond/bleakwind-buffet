using PointOfSale.SideCustomization;
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

/*
 * Author: Trevor Prondzinski
 * Class name: MainWindow.xaml.cs
 * Purpose: To allow ordering and customization of the entire menu
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Declares the main window with homepage
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            frame.NavigationService.Navigate(new WelcomePage());
        }

        /// <summary>
        /// Shows all the entrees available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void Entrees_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new EntreeLists());
        }

        /// <summary>
        /// Shows all the entrees available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void EntreesClick(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new EntreeLists());
        }

        /// <summary>
        /// Shows all the drink buttons available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new DrinkList());
        }

        /// <summary>
        /// Shows all the side buttons available
        /// </summary>
        /// <param name="sender"> button</param>
        /// <param name="e">button being sent</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new SideList());
        }
    }
}
