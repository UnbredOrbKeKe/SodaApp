using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SodaDispenser.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings1 : ContentPage
    {
        public Settings1()
        {
            InitializeComponent();

            //Zet de entry text naar wat er in de key (Drank1-8) staat en al staat er niks in laat hij hem leeg
            Drank1.Text = Preferences.Get("Drank1", string.Empty);
            Drank2.Text = Preferences.Get("Drank2", string.Empty);
            Drank3.Text = Preferences.Get("Drank3", string.Empty);
            Drank4.Text = Preferences.Get("Drank4", string.Empty);
            Drank5.Text = Preferences.Get("Drank5", string.Empty);
            Drank6.Text = Preferences.Get("Drank6", string.Empty);
            Drank7.Text = Preferences.Get("Drank7", string.Empty);
            Drank8.Text = Preferences.Get("Drank8", string.Empty);
        }


        private void Save_Clicked(object sender, EventArgs e)
        {
            //Als iemand op de save knop drukt worden de waardes opgeslagen in hun eigen ID.
            //Als je de dranken opslaat dan staat er ook in de label erboven nog welke in welke pomp welke drank zit. Ook zorgt dit ervoor dat de entry leeg wordt.

            if (Drank1.Text != string.Empty)
            {
                Preferences.Set("Drank1", Drank1.Text);
                Pomp1.Text = " Pomp 1" + " = " + Preferences.Get("Drank1", string.Empty);
                Drank1.Text = string.Empty;
            }
            if (Drank2.Text != string.Empty)
            {
                Preferences.Set("Drank2", Drank2.Text);
                Pomp2.Text = " Pomp 2" + " = " + Preferences.Get("Drank2", string.Empty);
                Drank2.Text = string.Empty;
            }
            if (Drank3.Text != string.Empty)
            {
                Preferences.Set("Drank3", Drank3.Text);
                Pomp3.Text = " Pomp 3" + " = " + Preferences.Get("Drank3", string.Empty);
                Drank3.Text = string.Empty;
            }
            if (Drank4.Text != string.Empty)
            {
                Preferences.Set("Drank4", Drank4.Text);
                Pomp4.Text = " Pomp 4" + " = " + Preferences.Get("Drank4", string.Empty);
                Drank4.Text = string.Empty;
            }
            if (Drank5.Text != string.Empty)
            {
                Preferences.Set("Drank5", Drank5.Text);
                Pomp5.Text = " Pomp 5" + " = " + Preferences.Get("Drank5", string.Empty);
                Drank5.Text = string.Empty;
            }
            if (Drank6.Text != string.Empty)
            {
                Preferences.Set("Drank6", Drank6.Text);
                Pomp6.Text = " Pomp 6" + " = " + Preferences.Get("Drank6", string.Empty);
                Drank6.Text = string.Empty;
            }
            if (Drank7.Text != string.Empty)
            {
                Preferences.Set("Drank7", Drank7.Text);
                Pomp7.Text = " Pomp 7" + " = " + Preferences.Get("Drank7", string.Empty);
                Drank7.Text = string.Empty;
            }
            if (Drank8.Text != string.Empty)
            {
                Preferences.Set("Drank8", Drank8.Text);
                Pomp8.Text = " Pomp 8" + " = " + Preferences.Get("Drank8", string.Empty);
                Drank8.Text = string.Empty;
            }
            
        }

        private async void ClearButton_Clicked(object sender, EventArgs e)
        {
           var Verwijder = await DisplayAlert("Alert", "Weet u zeker dat u elk drankje wilt verwijdern hier?", "JA", "NEE");

            //Als je op ja drukt gaat hij dit uitvoeren
            if (Verwijder == true)
            {
                //verwijdert preferences van de dranken als je op de ja knop drukt.
                Preferences.Remove("Drank1");
                Preferences.Remove("Drank2");
                Preferences.Remove("Drank3");
                Preferences.Remove("Drank4");
                Preferences.Remove("Drank5");
                Preferences.Remove("Drank6");
                Preferences.Remove("Drank7");
                Preferences.Remove("Drank8");

                //Zorgt ervoor dat de drank in de label ook wordt verwijdert en dat er weer "pomp 1-8 =" komt te staan.
                Pomp1.Text = " Pomp 1 = " + Preferences.Get("Drank1", string.Empty);
                Pomp2.Text = " Pomp 2 = " + Preferences.Get("Drank2", string.Empty);
                Pomp3.Text = " Pomp 3 = " + Preferences.Get("Drank3", string.Empty);
                Pomp4.Text = " Pomp 4 = " + Preferences.Get("Drank4", string.Empty);
                Pomp5.Text = " Pomp 5 = " + Preferences.Get("Drank5", string.Empty);
                Pomp6.Text = " Pomp 6 = " + Preferences.Get("Drank6", string.Empty);
                Pomp7.Text = " Pomp 7 = " + Preferences.Get("Drank7", string.Empty);
                Pomp8.Text = " Pomp 8 = " + Preferences.Get("Drank8", string.Empty);

                await DisplayAlert("Alert", "Uw dranken zijn verwijderd", "OK");
            }

            //Als je niet op ja drukt (dus op nee) dan verwijdert hij niks
            else
            {
                await DisplayAlert("Alert", "Er is niks verwijdert", "OK");
            }
        }
    }
}