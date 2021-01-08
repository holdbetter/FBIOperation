using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FBIOperation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchStatsPage : ContentPage
    {
        public MatchStatsPage(Match match)
        {
            InitializeComponent();

            BindingContext = match;
            homeTeamScore.BindingContext = match.HomeTeamStats;
            guestTeamScore.BindingContext = match.GuestTeamStats;

            goBackButton.Clicked += async (sender, e) => await Navigation.PopAsync();
        }
    }
}