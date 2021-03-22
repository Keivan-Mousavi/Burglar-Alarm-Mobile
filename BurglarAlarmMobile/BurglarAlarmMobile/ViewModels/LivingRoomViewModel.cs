using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BurglarAlarmMobile.ViewModels
{
    public class LivingRoomViewModel
    {
        public Command<string> ControllerTV { get; set; }

        public LivingRoomViewModel()
        {
            ControllerTV = new Command<string>(OnControllerTV);
        }

        private async void OnControllerTV(string sender)
        {

        } 
    }
}
