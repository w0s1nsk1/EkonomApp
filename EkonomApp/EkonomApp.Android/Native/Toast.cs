﻿using Android.Widget;
using Android.App;
using EkonomApp.Droid;
[assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))]
namespace EkonomApp.Droid
{
    public class MessageAndroid : IMessage
    {
        public void LongAlert(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
        public void ShortAlert(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}