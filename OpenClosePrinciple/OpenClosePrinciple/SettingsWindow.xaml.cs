using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OpenClosePrinciple
{
    public partial class SettingsWindow : Window, ISettingsWindowWindow
    {
        public ObservableCollection<ISettingsView> SettingsViews { get; set; }

        public SettingsWindow(IEnumerable<ISettingsView> settingsViews,
            ApplicationContext applicationContext)
        {
            InitializeComponent();

            var processedSettingsViews = settingsViews
                .Where(v => v.CanShow(applicationContext))
                .OrderBy(v => v.OrderNumber);

            SettingsViews = new ObservableCollection<ISettingsView>(processedSettingsViews);            

            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if(button == null)
            {
                return;
            }

            var view = button.DataContext as ISettingsView;

            if(view == null)
            {
                return;
            }

            view.Show();
        }
    }

    public interface ISettingsWindowWindow
    {
        void Show();
    }
}
