using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private string dots = "";
        private string dashes = "";
        private string space = "";

        void Dot_Clicked(System.Object sender, System.EventArgs e)
        {
            dots += ".";

            DotsAndDashes.Text = dots;
            
        }


        void Dash_Clicked(System.Object sender, System.EventArgs e)
        {
            dashes += "=";

            DotsAndDashes.Text = dots;

        }

        void Space_Clicked(System.Object sender, System.EventArgs e)
        {
            space += " ";

            DotsAndDashes.Text = space;

            if(space.Length == 2)
            {
                var words = Morse.MorseCoder(dots + dashes);
                LettersAndWords.Text = words.ToString();
            }

        }



    }
}
