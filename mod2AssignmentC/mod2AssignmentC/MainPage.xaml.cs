using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mod2AssignmentC
{
    public partial class MainPage : ContentPage
    {
        private string currentMorseCode = "";
        private string decodedText = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Dot_Clicked(object sender, EventArgs e)
        {
            currentMorseCode += ".";
            UpdateDotsAndDashesLabel();

        }

        private void Dash_Clicked(object sender, EventArgs e)
        {
            currentMorseCode += "-";
            UpdateDotsAndDashesLabel();
        }

        private void Space_Clicked(object sender, EventArgs e)
        {
            if (currentMorseCode == "")
            {
                decodedText += " "; // Add a space for a new word
            }
            else
            {
                char letter = Morse.MorseCoder(currentMorseCode);
                decodedText += letter;
            }

            currentMorseCode = ""; // Reset the current Morse code
            UpdateDotsAndDashesLabel();
            UpdateLettersAndWordsLabel();
        }

        private void UpdateDotsAndDashesLabel()
        {
            dotsAndDashesLabel.Text = currentMorseCode;
            dotsAndDashesLabel2.Text = currentMorseCode;
        }

        private void UpdateLettersAndWordsLabel()
        {
            lettersAndWordsLabel.Text = decodedText;
            
        }
    }
}
