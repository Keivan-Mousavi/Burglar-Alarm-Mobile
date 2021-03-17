﻿using BurglarAlarmMobile.Models;
using BurglarAlarmMobile.Services;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BurglarAlarmMobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override async void OnStart()
        {
            string deviceId = DependencyService.Get<INotificationUser>().GetToken();

            using (var client = new HttpClient())
            {
                var responce = await client.GetAsync(string.Format("http://burglaralarm.persianprogrammer.com/ManageNotification/AddDeviceIdNotification?key={0}", deviceId));

                if (responce.IsSuccessStatusCode && responce.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = await responce.Content.ReadAsStringAsync();
                }
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
