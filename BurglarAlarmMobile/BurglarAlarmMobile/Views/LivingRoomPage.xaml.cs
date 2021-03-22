using BurglarAlarmMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BurglarAlarmMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LivingRoomPage : ContentPage
    {
        public LivingRoomPage()
        {
            InitializeComponent();

            BindingContext = new LivingRoomViewModel();
        }
    }
}