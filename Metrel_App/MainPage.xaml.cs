using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Metrel_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Decode_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Decode button was clicked");
        }


        private void Callback_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Callback button was clicked");
        }
    }
}
