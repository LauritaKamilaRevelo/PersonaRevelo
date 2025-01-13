using PersonaRevelo.Models;
using System.Collections.Generic;

namespace PersonaRevelo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = " ";

            App.KRPersonRepo.AddNewPerson(newPerson.Text);
            statusMessage.Text = App.KRPersonRepo.StatusMessage;
        }

        public void OnGetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            List<KRPerson> people = App.KRPersonRepo.GetAllPeople();
            peopleList.ItemsSource = people;
        }
    }

}
