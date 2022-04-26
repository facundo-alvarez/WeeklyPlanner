using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using WeeklyPlanner.ViewModels;
using WeeklyPlanner.Modals;

namespace WeeklyPlanner
{
    public partial class MainWindow : Window
    {
        MainWindowViewModel dc;


        public MainWindow()
        {
            InitializeComponent();
            dc = mainGrid.DataContext as WeeklyPlanner.ViewModels.MainWindowViewModel;
            this.DataContext = dc;
        }


        private void AddDayEvent_Click(object sender, RoutedEventArgs e)
        {
            var day = (Button)sender;
            var dayName = (string)day.Tag;

            AddDayEventModal m = new AddDayEventModal(dayName, dc);

            m.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            m.ShowDialog();
        }
    }
}
