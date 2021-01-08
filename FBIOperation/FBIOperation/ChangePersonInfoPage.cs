using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FBIOperation
{
    public class ChangePersonInfoPage : ContentPage
    {
        public ChangePersonInfoPage()
        {
            Entry personName = new Entry();
            personName.SetBinding(Entry.TextProperty, "Name");
            Entry personSurname = new Entry();
            personSurname.SetBinding(Entry.TextProperty, "Surname");
            Entry personAge = new Entry();
            personAge.SetBinding(Entry.TextProperty, "Age");

            Button goBack = new Button()
            {
                Text = "Сохранить информацию"
            };

            goBack.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    personName,
                    personSurname,
                    personAge,
                    goBack
                }
            };
        }
    }
}