using PointOfSale.EntreeCustomization;
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
 * Class name: EntreeLists.cs
 * Purpose: To allow ordering and customization of the entrees
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeLists.xaml
    /// </summary>
    public partial class EntreeLists : Page
    {
        /// <summary>
        /// initializes the entree list
        /// </summary>
        public EntreeLists()
        {
            InitializeComponent();
        }

        /// <summary>
        /// navigates to the briar burger cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void BriarBurger_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Briarhear_Burgers());
        }

        /// <summary>
        /// navigates to the double draugr cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Double_Draugr());
        }

        /// <summary>
        /// navigates to the Thalmor triple cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Thalmor_Triple());
        }

        /// <summary>
        /// navigates to the smokehouse skeleton cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Smokehouse_Skeleton());
        }

        /// <summary>
        /// navigates to the green orc omelette cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void GardenOrcOmelete_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GardenOrc_Omelette());
        }

        /// <summary>
        /// navigates to the philly poacher cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PhillyPoacher());
        }

        /// <summary>
        /// navigates to the thugs t-bone cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Thugs_T_Bone());
        }
    }
}
