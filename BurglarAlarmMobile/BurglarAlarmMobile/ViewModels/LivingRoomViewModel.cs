using System.Net.Http;
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
            try
            {
                using (var client = new HttpClient())
                {
                    var responce = await client.GetAsync(string.Format("http://burglaralarm.persianprogrammer.com/ManageNotification/AddControllerTV?serial={0}&sendNEC={1}", "d6ac5b88-35e9-461f-b911-2f68d4cb9c44", sender));

                    if (responce.IsSuccessStatusCode && responce.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var json = await responce.Content.ReadAsStringAsync();
                    }
                }
            }
            catch
            {

            }
        } 
    }
}
