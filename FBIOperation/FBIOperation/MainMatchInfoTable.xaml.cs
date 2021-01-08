using FBIOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBIOperation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMatchInfoTable : ContentView
    {
        public MainMatchInfoTable()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            MatchEvent matchEvent = this.BindingContext as MatchEvent;
            Team homeTeam = matchEvent.HomeTeam;
            Team guestTeam = matchEvent.GuestTeam;

            homeTeamImage.Source = ImageSource.FromResource(homeTeam.Icon, typeof(MatchOverviewPage).GetTypeInfo().Assembly);
            guestTeamImage.Source = ImageSource.FromResource(guestTeam.Icon, typeof(MatchOverviewPage).GetTypeInfo().Assembly);
        }
    }
}