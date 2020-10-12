using BleakwindBuffet.Data.Entrees;
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


        public event EventHandler<CustomizationSelector> CurrentSelection;
        /// <summary>
        /// initializes the entree list
        /// </summary>
        public EntreeLists()
        {
            InitializeComponent();
        }

        MainWindow window = (MainWindow)Application.Current.MainWindow;

        // public MainWindow mainwindow = new MainWindow();
        /// <summary>
        /// navigates to the briar burger cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void BriarBurger_Click(object sender, RoutedEventArgs e)
        {
            var bb = new BriarheartBurger();


            Briarhear_Burgers bBurger = new Briarhear_Burgers();


            this.NavigationService.Navigate(bBurger);
            bBurger.DataContext = bb;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = bb });
            window.finallist.Add(bb);

          
        }

        /// <summary>
        /// navigates to the double draugr cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void DoubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            var tt = new DoubleDraugr();


            Double_Draugr tBurger = new Double_Draugr();


            this.NavigationService.Navigate(tBurger);
            tBurger.DataContext = tt;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = tt });
            window.finallist.Add(tt);

        }

        /// <summary>
        /// navigates to the Thalmor triple cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void ThalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            var ct = new ThalmorTriple();


            Thalmor_Triple tripBurg = new Thalmor_Triple();


            this.NavigationService.Navigate(tripBurg);
            tripBurg.DataContext = ct;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = ct });
            window.finallist.Add(ct);
        }

        /// <summary>
        /// navigates to the smokehouse skeleton cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void SmokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            var ss = new SmokehouseSkeleton();


            Smokehouse_Skeleton smoke = new Smokehouse_Skeleton();


            this.NavigationService.Navigate(smoke);
            smoke.DataContext = ss;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = ss });
            window.finallist.Add(ss);
        }

        /// <summary>
        /// navigates to the green orc omelette cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void GardenOrcOmelete_Click(object sender, RoutedEventArgs e)
        {
            var oo = new GardenOrcOmelette();


            GardenOrc_Omelette orcOm = new GardenOrc_Omelette();


            this.NavigationService.Navigate(orcOm);
            orcOm.DataContext = oo;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = oo });
            window.finallist.Add(oo);
        }

        /// <summary>
        /// navigates to the philly poacher cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void PhillyPoacher_Click(object sender, RoutedEventArgs e)
        {
            var pp = new PhillyPoacher();


            Philly_Poacher phillyPoach = new Philly_Poacher();


            this.NavigationService.Navigate(phillyPoach);
            phillyPoach.DataContext = pp;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = pp });
            window.finallist.Add(pp);
        }

        /// <summary>
        /// navigates to the thugs t-bone cutomizations
        /// </summary>
        /// <param name="sender">button being sent</param>
        /// <param name="e">button pressed</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tb = new ThugsTBone();


            Thugs_T_Bone tBone = new Thugs_T_Bone();


            this.NavigationService.Navigate(tBone);
            tBone.DataContext = tb;
            CurrentSelection?.Invoke(this, new CustomizationSelector() { orderItem = tb });
            window.finallist.Add(tb);
        }
    }
}
