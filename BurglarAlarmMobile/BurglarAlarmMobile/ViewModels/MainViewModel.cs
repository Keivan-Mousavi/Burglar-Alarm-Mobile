using BurglarAlarmMobile.Views;
using Xamarin.Forms;

namespace BurglarAlarmMobile.ViewModels
{
    public class MainViewModel
    {
        public Command LivingRoomTap { get; set; }

        public MainViewModel()
        {
            LivingRoomTap = new Command(LivingRoomTapped);
        }

        private async void LivingRoomTapped()
        {
            await Shell.Current.GoToAsync($"{nameof(LivingRoomPage)}");
        }
    }
}
