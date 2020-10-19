using BleakwindBuffet.Data.Sides;
using PointOfSale.SideCustomization;
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
 * Class name: SideList.xaml.cs
 * Purpose: To allow ordering and customization of the sides
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideList.xaml
    /// </summary>
    public partial class SideList : UserControl
    {
        public event EventHandler<CustomizationSelector> CurrentSelection;

        MainWindow ancestor;
        MainWindow window = (MainWindow)Application.Current.MainWindow;
        /// <summary>
        /// initializes sidelist xaml
        /// </summary>
        public SideList(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }

        /// <summary>
        /// navigates to the vokun salad cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void VokunSalad_Click(object sender, RoutedEventArgs e)
        {
            var vs = new VokunSalad();



            VokunSaladCustom sc = new VokunSaladCustom(ancestor);

           // NavigationService.Navigate(sc);
            sc.DataContext = vs;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = vs });
            window.DisplayCurrentOrder();
            ancestor.SwitchScreen(Screen.custVokun, vs);

        }

        /// <summary>
        /// navigates to the fried miraak cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void FriedMiraak_Click(object sender, RoutedEventArgs e)
        {
            var fm = new FriedMiraak();



            FriedMiraakCustom sc = new FriedMiraakCustom(ancestor);

           // NavigationService.Navigate(sc);
            sc.DataContext = fm;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = fm });
            window.DisplayCurrentOrder();
            ancestor.SwitchScreen(Screen.custFried, fm);
        }

        /// <summary>
        /// navigates to the mad otar grits cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void MadOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            var og = new MadOtarGrits();



            MadOtarGritsCustom sc = new MadOtarGritsCustom(ancestor);

           // NavigationService.Navigate(sc);
            sc.DataContext = og;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = og });
            window.DisplayCurrentOrder();
            ancestor.SwitchScreen(Screen.custMad, og);
        }

        /// <summary>
        /// navigates to the dragonborn waffle fries cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void DragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            var dw = new DragonbornWaffleFries();

            DragonbornWaffleFriesCustom sc = new DragonbornWaffleFriesCustom(ancestor);

           

           // NavigationService.Navigate(sc);
            sc.DataContext = dw;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = dw });
            window.DisplayCurrentOrder();
            ancestor.SwitchScreen(Screen.custMarkarth, dw);
        }
    }
}
