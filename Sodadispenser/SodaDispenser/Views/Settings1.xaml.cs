using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            
        }

        private void Drank1_TextChanged(object sender, TextChangedEventArgs e)
        {
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
    }
}