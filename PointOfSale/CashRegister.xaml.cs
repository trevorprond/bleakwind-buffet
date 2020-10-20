using BleakwindBuffet.Data;
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
 * Class name: CashRegister.xaml.cs
 * Purpose: To allow transactions to be complete
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        MainWindow ancestor;


        Order curOrder = new Order();
        RegistrarFunction Cash;

        /// <summary>
        /// Cash Register constructor
        /// </summary>
        /// <param name="ancestor"></param>
        /// <param name="order"></param>
        public CashRegister(MainWindow ancestor, Order order)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            curOrder = order;
            Cash = new RegistrarFunction(order);
            DataContext = Cash;
            

        }
        

        /// <summary>
        /// Change due click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cash.ChangeDue(curOrder.Total);
        }
    }
}
