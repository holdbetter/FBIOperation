using FBIOperation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBIOperation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchStatsDetailPage : ContentPage
    {
        public MatchEvent MatchEvent { get; set; }

        public MatchStatsDetailPage(MatchEvent matchEvent)
        {
            this.MatchEvent = matchEvent;

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
        }

        protected override void OnAppearing()
        {
            NavigationPage mainPage = App.Current.MainPage as NavigationPage;
            mainPage.SetBinding(NavigationPage.BarBackgroundColorProperty, new Binding()
            {
                Source = MatchEvent,
                Path = "SportTypeColor"
            });
            mainPage.BarTextColor = Color.FromHex("#F3F3F3");

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            base.OnDisappearing();
        }
    }
}