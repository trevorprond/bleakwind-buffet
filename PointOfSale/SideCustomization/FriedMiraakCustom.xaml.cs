﻿using System;
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
    /// Interaction logic for FriedMiraakCustom.xaml
    /// </summary>
    public partial class FriedMiraakCustom : UserControl
    {
        MainWindow ancestor;
        public FriedMiraakCustom(MainWindow ancestor)
        {
            InitializeComponent();
            this.ancestor = ancestor;
        }
    }
}
