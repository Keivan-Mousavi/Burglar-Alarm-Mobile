using BurglarAlarmMobile.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BurglarAlarmMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        private void LivingRoomTap_Tapped(object sender, EventArgs e)
        {
            //LivingRoom.TranslateTo(100, 0, 500, Easing.CubicIn);
            //LivingRoom.TranslateTo(0, 0);
        }
    }
}