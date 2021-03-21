using BurglarAlarmMobile.Views;
using System;
using Xamarin.Forms;

namespace BurglarAlarmMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LivingRoomPage), typeof(LivingRoomPage));
        }
    }
}
