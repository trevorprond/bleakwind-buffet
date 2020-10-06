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
            var ss = new SailorSoda();


            Sailor_Soda Soda = new Sailor_Soda();


            this.NavigationService.Navigate(Soda);
            Soda.DataContext = ss;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = ss });
            window.finallist.Add(ss);
 
        }

        /// <summary>
        /// navigates to the markarth milk cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void MarkarthMilk_Click(object sender, RoutedEventArgs e)
        {
            var mm = new MarkarthMilk();


            Markarth_Milk Milk = new Markarth_Milk();


            this.NavigationService.Navigate(Milk);
            Milk.DataContext = mm;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = mm });
            window.finallist.Add(mm);
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
     

        }

        /// <summary>
        /// navigates to the candlehearth coffee cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void CandlehearthCoffe_Click(object sender, RoutedEventArgs e)
        {
             var cc = new CandlehearthCoffee();


            Candlehearth_Coffee Coffee = new Candlehearth_Coffee();

            
            this.NavigationService.Navigate(Coffee);
            Coffee.DataContext = cc;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = cc });
            window.finallist.Add(cc);
        }

        /// <summary>
        /// navigates to the warrior water cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void WarriorWater(object sender, RoutedEventArgs e)
        {
            var ww = new WarriorWater();


            Warrior_Water Water = new Warrior_Water();


            this.NavigationService.Navigate(Water);
            Water.DataContext = ww;
            currentSelection?.Invoke(this, new CustomizationSelector() { orderItem = ww });
            window.finallist.Add(ww);
        }
    }
}
