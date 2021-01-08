using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FBIOperation
{
    public class PersonDataPage : ContentPage
    {
        Person person = new Person()
        {
            Name = "Vilen",
            Surname = "Evseev",
            Age = 8888
        };

        public PersonDataPage()
        { 
            Label personName = new Label();
            personName.SetBinding(Label.TextProperty, "Name");
            Label personSurname = new Label();
            personSurname.SetBinding(Label.TextProperty, "Surname");
            Label personAge = new Label();
            personAge.SetBinding(Label.TextProperty, "Age");

            Button openChangingPage = new Button()
            {
                Text = "Изменить информацию"
            };

            openChangingPage.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ChangePersonInfoPage() { BindingContext = person });
            };

            Content = new StackLayout
            {
                BindingContext = person,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    personName,
                    personSurname,
                    personAge,
                    openChangingPage
                }
            };
        }
    }
}