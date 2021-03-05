using BurglarAlarmMobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BurglarAlarmMobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}