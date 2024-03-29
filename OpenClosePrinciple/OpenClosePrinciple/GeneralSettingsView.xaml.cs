﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OpenClosePrinciple
{
    /// <summary>
    /// Interaction logic for GeneralSettingsView.xaml
    /// </summary>
    public partial class GeneralSettingsView : Window, ISettingsView
    {
        public GeneralSettingsView()
        {
            Title = "General Settings";
            InitializeComponent();
        }

        public double OrderNumber => 1;

        public bool CanShow(ApplicationContext context)
        {
            return true;
        }
    }
}
