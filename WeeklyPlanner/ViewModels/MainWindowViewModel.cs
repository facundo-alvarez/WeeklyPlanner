using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WeeklyPlanner.Models;

namespace WeeklyPlanner.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<DayEvent> MondayEvents { get; set; }
        public ObservableCollection<DayEvent> TuesdayEvents { get; set; }
        public ObservableCollection<DayEvent> WednesdayEvents { get; set; }
        public ObservableCollection<DayEvent> ThursdayEvents { get; set; }
        public ObservableCollection<DayEvent> FridayEvents { get; set; }
        public ObservableCollection<DayEvent> SaturdayEvents { get; set; }
        public ObservableCollection<DayEvent> SundayEvents { get; set; }


        public MainWindowViewModel()
        {
            AddDayEventCommand = new RelayCommand<string>(AddEvent);
            MondayEvents = new ObservableCollection<DayEvent>();
            TuesdayEvents = new ObservableCollection<DayEvent>();
            WednesdayEvents = new ObservableCollection<DayEvent>();
            ThursdayEvents = new ObservableCollection<DayEvent>();
            FridayEvents = new ObservableCollection<DayEvent>();
            SaturdayEvents = new ObservableCollection<DayEvent>();
            SundayEvents = new ObservableCollection<DayEvent>();
        }

        public ICommand AddDayEventCommand { get; }

        public string Day { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }


        private void AddEvent(string day)
        {
            switch (day)
            {
                case "Monday":
                    MondayEvents.Add(new DayEvent(Title,Description));
                    break;

                case "Tuesday":
                    TuesdayEvents.Add(new DayEvent(Title, Description));
                    break;

                case "Wednesday":
                    WednesdayEvents.Add(new DayEvent(Title, Description));
                    break;

                case "Thursday":
                    ThursdayEvents.Add(new DayEvent(Title, Description));
                    break;

                case "Friday":
                    FridayEvents.Add(new DayEvent(Title, Description));
                    break;

                case "Saturday":
                    SaturdayEvents.Add(new DayEvent(Title, Description));
                    break;

                case "Sunday":
                    SundayEvents.Add(new DayEvent(Title, Description));
                    break;
            }
        }
    }


}
