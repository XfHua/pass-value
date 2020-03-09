using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App163
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public string previouspagevalue;

        public MainPage()
        {
            InitializeComponent();

            previouspagevalue = "I'm previouspagevalue";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            //if you set the lblEndDT.Text = "someValue"; in the secondPage, there is no need to update it here
            lblEndDT.Text = previouspagevalue;
        }

        private void btnOffline_Clicked(object sender, EventArgs e)
        {
            //Pass the parametere you need when you go to SecondPage 
            //Navigation.PushAsync(new SecondPage(this, lblEndDT));

            Navigation.PushAsync(new SecondPage(this, lblEndDT, MyImageButton));

            string currentDT = DateTime.Now.ToString();
            lblStartDT.Text = currentDT;

        }
    }
}
