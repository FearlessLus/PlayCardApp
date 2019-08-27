using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlayCardApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // This is from 27/8-19
            // veriveri fun
        }

        private void NewGamePessed(object sender, EventArgs e)
        {
            (sender as Button).Text = "Lets go from here";
        }
        
        private void JoinGamePressed(object sender, EventArgs e)
        {
            (sender as Button).Text = "Second button pressed";
        }
    }
}
