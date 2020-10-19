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

namespace PointOfSale.SideCustomization
{
    /// <summary>
    /// Interaction logic for VokunSaladCustom.xaml
    /// </summary>
    public partial class VokunSaladCustom : UserControl
    {
        MainWindow ancestor;
        public VokunSaladCustom(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }
    }
}
