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
    /// Interaction logic for MadOtarGritsCustom.xaml
    /// </summary>
    public partial class MadOtarGritsCustom : UserControl
    {
        MainWindow ancestor;
        public MadOtarGritsCustom(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }
    }
}
