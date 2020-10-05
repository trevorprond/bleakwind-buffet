using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.DrinkCustomization;
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
 * Class name: drinklist.xaml.cs
 * Purpose: To allow ordering and customization of the drinks
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkList.xaml
    /// </summary>
    public partial class DrinkList : Page
    {
       

        

        /* public List<IOrderItem> drinklist
        {
            get { return drinklist;  }
        }*/
        /// <summary>
        /// intitializes drinklist xaml
        /// </summary>
        public DrinkList()
        {
            InitializeComponent();
            
        }

         MainWindow window = (MainWindow)Application.Current.MainWindow;

        public event EventHandler<CustomizationSelector> currentSelection;
        /// <summary>
        /// navigates to the sailor soda cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void SailorSoda_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Sailor_Soda());
        }

        /// <summary>
        /// navigates to the markarth milk cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Markarth_Milk());
        }

         
        /// <summary>
        /// navigates to the aretino apple juice cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void AretinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            var Aj = new AretinoAppleJuice();


            AretinoApple_Juice AppleJuice = new AretinoApple_Juice();

            
            this.NavigationService.Navigate(AppleJuice);
            AppleJuice.DataContext = Aj;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = Aj });
            window.finallist.Add(Aj);
            Console.WriteLine(window.finallist);

        }

        /// <summary>
        /// navigates to the candlehearth coffee cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void CandlehearthCoffe_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Candlehearth_Coffee());
        }

        /// <summary>
        /// navigates to the warrior water cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void WarriorWater(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Warrior_Water());
        }
    }
}
