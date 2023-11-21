using System.Collections.ObjectModel;

namespace PatienInfo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        App thisApp = Microsoft.Maui.Controls.Application.Current as App;
        private MySQLiteDatabase Hiking_trip;
        public MainPage()
        {
            InitializeComponent();
            this.cbxLevel.Items.Add("High");
            this.cbxLevel.Items.Add("Medium");
            this.cbxLevel.Items.Add("Low");

            this.cbxTD.Items.Add("Easy");
            this.cbxTD.Items.Add("Normal");
            this.cbxTD.Items.Add("Hard");

            thisApp.PatientList = new ObservableCollection<Patient>();
            Hiking_trip = new MySQLiteDatabase();
        }
        private async void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Confirmation", "Do you want to submit?", "OK", "Cancel");
            if (response)
            {                Patient p = new Patient(count++,
                    this.txtName.Text,
                    this.txtDistance.Text,
                    this.txtElevation.Text,
                    this.dtpDate.Date,
                    this.swtPA.SelectedItem.ToString(),
                    this.cbxLevel.SelectedItem.ToString(),
                    this.txtLocation.Text,
                    this.cbxTD.SelectedItem.ToString(),
                    this.txtDescriptions.Text);
                thisApp.PatientList.Add(p);
                await DisplayAlert("Information", "Information submitted", "OK");
            }
            SemanticScreenReader.Announce(btnSubmit.Text);
            Navigation.PushModalAsync(new PatientList(), true);


        }
        private void btnView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PatientList(), true);
        }
        private void btnLoad_Hiking_Clicked (object sender, EventArgs e)
        {
            thisApp.PatientList = Hiking_trip.loadPatient();
        }
    }
}