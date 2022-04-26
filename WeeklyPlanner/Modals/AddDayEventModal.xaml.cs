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
using WeeklyPlanner.ViewModels;

namespace WeeklyPlanner.Modals
{
    /// <summary>
    /// Interaction logic for AddDayEventModal.xaml
    /// </summary>
    public partial class AddDayEventModal : Window
    {
        public AddDayEventModal(string d, MainWindowViewModel mw)
        {
            InitializeComponent();
            this.DataContext = mw;
            day.Content = d;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
