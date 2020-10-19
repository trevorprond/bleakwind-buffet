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
 * Class name: WelcomePage.xaml.cs
 * Purpose: To provide a page to get back after ordering
 */
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : UserControl
    {
        public MainWindow Ancestor { get; set; }
        public WelcomePage()
        {
            InitializeComponent();
        }
    }
}
