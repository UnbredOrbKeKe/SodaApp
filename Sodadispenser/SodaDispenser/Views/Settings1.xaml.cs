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

        private void Drank1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Zet de pomp1 label naar Pomp 1 = "wat je maar invult". Ook zet die hetgene wat je invult in een string
            Pomp1.Text = " Pomp 1" + " = " + Drank1.Text;

            string Pomp1Drank = Drank1.Text;
        }

        private void Drank2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pomp2.Text = " Pomp 2" + " = " + Drank2.Text;

            string Pomp2Drank = Drank2.Text;
        }

        private void Drank3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pomp3.Text = " Pomp 3" + " = " + Drank3.Text;

            string Pomp3Drank = Drank3.Text;
        }

        private void Drank4_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pomp4.Text = " Pomp 4" + " = " + Drank4.Text;

            string Pomp4Drank = Drank4.Text;
        }

        private void Drank5_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pomp5.Text = " Pomp 5" + " = " + Drank5.Text;

            string Pomp5Drank = Drank5.Text;
        }

        private void Drank6_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pomp6.Text = " Pomp 6" + " = " + Drank6.Text;

            string Pomp6Drank = Drank6.Text;
        }

        private void Drank7_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pomp7.Text = " Pomp 7" + " = " + Drank7.Text;

            string Pomp7Drank = Drank7.Text;
        }

        private void Drank8_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pomp8.Text = " Pomp 8" + " = " + Drank8.Text;

            string Pomp8Drank = Drank8.Text;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("Drank1", Drank1.Text);
            Preferences.Set("Drank2", Drank2.Text);
            Preferences.Set("Drank3", Drank3.Text);
            Preferences.Set("Drank4", Drank4.Text);
            Preferences.Set("Drank5", Drank5.Text);
            Preferences.Set("Drank6", Drank6.Text);
            Preferences.Set("Drank7", Drank7.Text);
            Preferences.Set("Drank8", Drank8.Text);
        }
    }
}