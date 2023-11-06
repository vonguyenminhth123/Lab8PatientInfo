using System.Collections.ObjectModel;

namespace Lab8PatientInfo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        App thisApp = Microsoft.Maui.Controls.Application.Current as App;
        private MySQLiteDatabase myDB;

        public MainPage()
        {
            thisApp.HikeList = new ObservableCollection<Hike>();
            myDB = new MySQLiteDatabase();
        }

        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Confirmation", "Do you want to submit?", "OK", "Cancel");
            if (response)
            {
                Hike h = new Hike(count++, this.txtName.Text,
                    this.txtLocation.Text, this.dtpDateofHike.Date,
                    this.swtAvailability.IsToggled,
                    this.txtLength.Text,
                    this.cbxLevel.SelectedItem.ToString(),
                    this.txtDescription.Text);
                thisApp.HikeList.Add(h);
                myDB.insertHike(h);
                await DisplayAlert("Information", "Information Submitted", "OK");
            }
            //SemanticScreenReader.Announce(btnSubmit.Text);
        }
        private void btnView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HikeList(), true);
        }
        private void btnLoad_Hike_Clicked(object sender, EventArgs e)
        {
            thisApp.HikeList = myDB.loadHike();
        }
    }
}