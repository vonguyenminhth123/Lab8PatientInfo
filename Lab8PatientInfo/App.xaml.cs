using System.Collections.ObjectModel;

namespace Lab8PatientInfo
{
    public partial class App : Application
    {
        public ObservableCollection<Hike> HikeList;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}