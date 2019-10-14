using System;
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
    /// Interaction logic for AdminSettingsView.xaml
    /// </summary>
    public partial class AdminSettingsView : Window, ISettingsView
    {
        public AdminSettingsView()
        {
            InitializeComponent();
        }

        public double OrderNumber => 10;

        public bool CanShow(ApplicationContext context)
        {
            return context.IsAdmin;
        }
    }
}
