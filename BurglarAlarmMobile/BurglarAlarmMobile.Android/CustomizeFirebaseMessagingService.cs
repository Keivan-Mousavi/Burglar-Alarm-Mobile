using Android.App;
using Android.Content;
using Firebase.Messaging;

namespace BurglarAlarmMobile.Droid
{
    [Service(Exported = true)]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class CustomizeFirebaseMessagingService : FirebaseMessagingService
    {
        public CustomizeFirebaseMessagingService()
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override void OnMessageReceived(RemoteMessage message)
        {
            base.OnMessageReceived(message);
            new NotificationHelper().CreateNotification(message.GetNotification().Title, message.GetNotification().Body);
        }
    }
}