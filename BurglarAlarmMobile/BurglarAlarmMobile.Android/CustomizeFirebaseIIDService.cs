using Android.App;
using Android.Content;
using Firebase.Iid;

namespace BurglarAlarmMobile.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT" })]
    public class CustomizeFirebaseIIDService : FirebaseInstanceIdService
    {
        const string TAG = "CustomizeFirebaseIIDService";
        public override void OnTokenRefresh()
        {
            var refreshedToken = FirebaseInstanceId.Instance.Id;
            SendRegistrationToServer(refreshedToken);
        }

        void SendRegistrationToServer(string token)
        {
            // send this token to server
        }
    }
}