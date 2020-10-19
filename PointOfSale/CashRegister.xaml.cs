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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        MainWindow ancestor;

        //MainWindow window = (MainWindow)Application.Current.MainWindow;

        Order curOrder = new Order();
        RegistrarFunction Cash;

        public CashRegister(MainWindow ancestor, Order order)
        {
            InitializeComponent();
            this.ancestor = ancestor;
            curOrder = order;
            Cash = new RegistrarFunction(order);
            DataContext = Cash;
            

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cash.ChangeDue(curOrder.Total);
        }
    }
}
