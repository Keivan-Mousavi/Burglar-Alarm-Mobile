using System;

namespace BurglarAlarmMobile.Models
{
    public interface INotification
    {
        void CreateNotification(string title, string message);
    }
}
