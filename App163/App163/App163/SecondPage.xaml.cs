using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App163
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        Label MainPagelblEndDT;
        MainPage mainPage;
        ImageButton myImageBtn;
        public SecondPage()
        {
            InitializeComponent();
        }

        public SecondPage(MainPage mainP,Label lblEndDT)
        {
            InitializeComponent();

            //Get the lblEndDT reference here
            MainPagelblEndDT = lblEndDT;
            //Get the MainPage reference here
            mainPage = mainP;
        }

        public SecondPage(MainPage mainP, Label lblEndDT, ImageButton imageBtn)
        {
            InitializeComponent();

            //Get the lblEndDT reference here
            MainPagelblEndDT = lblEndDT;
            //Get the MainPage reference here
            mainPage = mainP;
            //Get the ImageButton reference here
            myImageBtn = imageBtn;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {           
            string edt = DateTime.Now.ToString();

            //Use it
            MainPagelblEndDT.Text = edt;      
            
            mainPage.previouspagevalue = MainPagelblEndDT.Text;

            //change the source of imageBtn
            myImageBtn.Source = "Images1";
            myImageBtn.IsEnabled = true;

            Navigation.PopAsync();
        }
    }
}