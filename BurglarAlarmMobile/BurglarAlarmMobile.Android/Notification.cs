using Xamarin.Forms;
using BurglarAlarmMobile.Droid;
using BurglarAlarmMobile.Models;
using Firebase.Iid;

[assembly: Dependency(typeof(Notification))]
namespace BurglarAlarmMobile.Droid
{
    public class Notification : INotificationUser
    {
        public string GetToken()
        {
            var refreshedToken = FirebaseInstanceId.Instance.Token;
            return refreshedToken;
        }
    }
}