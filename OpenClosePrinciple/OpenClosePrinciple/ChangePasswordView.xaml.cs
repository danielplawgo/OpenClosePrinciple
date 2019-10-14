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
    /// Interaction logic for ChangePasswordView.xaml
    /// </summary>
    public partial class ChangePasswordView : Window, ISettingsView
    {
        public ChangePasswordView()
        {
            Title = "Change Password";
            InitializeComponent();
        }

        public double OrderNumber => 2;

        public bool CanShow(ApplicationContext context)
        {
            return true;
        }
    }
}
