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
    public partial class MatchOverviewPage : ContentPage
    {
        List<MatchEvent> footballEvents = new List<MatchEvent>()
        {
            new MatchEvent()
            {
                HomeTeam = new Team("ФК Москва", "FBIOperation.Images.moscowLogo.png"),
                GuestTeam = new Team("Сатурн", "FBIOperation.Images.saturnLogo.png"),
                League = new League("Тинькофф Премьер-Лига", "РПЛ"),
                HomeTeamScore = 2,
                GuestTeamScore = 1,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 8, 4),
                    new Stats("Удары в створ", 3, 2),
                    new Stats("Владение мячом", 54, 46)
                },
                SportType = SportEnum.Football
            },
            new MatchEvent()
            {
                HomeTeam = new Team("Рубин", "FBIOperation.Images.rubinLogo.png"),
                GuestTeam = new Team("Барселона", "FBIOperation.Images.barcaLogo.png"),
                League = new League("Лига Чемпионов", "ЛЧ"),
                HomeTeamScore = 2,
                GuestTeamScore = 3,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 5, 12),
                    new Stats("Удары в створ", 4, 8),
                    new Stats("Владение мячом", 44, 56)
                },
                SportType = SportEnum.Football
            },
            new MatchEvent()
            {
                HomeTeam = new Team("Челси", "FBIOperation.Images.chelseaLogo.png"),
                GuestTeam = new Team("Ливерпуль", "FBIOperation.Images.liverLogo.png"),
                League = new League("Английская Премьер-Лига", "АПЛ"),
                HomeTeamScore = 0,
                GuestTeamScore = 6,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 4, 10),
                    new Stats("Удары в створ", 1, 7),
                    new Stats("Владение мячом", 28, 62)
                },
                SportType = SportEnum.Football
            },
        };

        List<MatchEvent> hockeyEvents = new List<MatchEvent>()
        {
            new MatchEvent()
            {
                HomeTeam = new Team("ФК Москва", "FBIOperation.Images.moscowLogo.png"),
                GuestTeam = new Team("Сатурн", "FBIOperation.Images.saturnLogo.png"),
                League = new League("Тинькофф Премьер-Лига", "РПЛ"),
                HomeTeamScore = 2,
                GuestTeamScore = 1,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 8, 4),
                    new Stats("Удары в створ", 3, 2),
                    new Stats("Владение мячом", 54, 46)
                },
                SportType = SportEnum.Hockey
            },
            new MatchEvent()
            {
                HomeTeam = new Team("Рубин", "FBIOperation.Images.rubinLogo.png"),
                GuestTeam = new Team("Барселона", "FBIOperation.Images.barcaLogo.png"),
                League = new League("Лига Чемпионов", "ЛЧ"),
                HomeTeamScore = 2,
                GuestTeamScore = 3,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 5, 12),
                    new Stats("Удары в створ", 4, 8),
                    new Stats("Владение мячом", 44, 56)
                },
                SportType = SportEnum.Hockey
            },
            new MatchEvent()
            {
                HomeTeam = new Team("Челси", "FBIOperation.Images.chelseaLogo.png"),
                GuestTeam = new Team("Ливерпуль", "FBIOperation.Images.liverLogo.png"),
                League = new League("Английская Премьер-Лига", "АПЛ"),
                HomeTeamScore = 0,
                GuestTeamScore = 6,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 4, 10),
                    new Stats("Удары в створ", 1, 7),
                    new Stats("Владение мячом", 28, 62)
                },
                SportType = SportEnum.Hockey
            },
        };

        List<MatchEvent> basketballEvents = new List<MatchEvent>()
        {
            new MatchEvent()
            {
                HomeTeam = new Team("ФК Москва", "FBIOperation.Images.moscowLogo.png"),
                GuestTeam = new Team("Сатурн", "FBIOperation.Images.saturnLogo.png"),
                League = new League("Тинькофф Премьер-Лига", "РПЛ"),
                HomeTeamScore = 2,
                GuestTeamScore = 1,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 8, 4),
                    new Stats("Удары в створ", 3, 2),
                    new Stats("Владение мячом", 54, 46)
                },
                SportType = SportEnum.Basketball
            },
            new MatchEvent()
            {
                HomeTeam = new Team("Рубин", "FBIOperation.Images.rubinLogo.png"),
                GuestTeam = new Team("Барселона", "FBIOperation.Images.barcaLogo.png"),
                League = new League("Лига Чемпионов", "ЛЧ"),
                HomeTeamScore = 2,
                GuestTeamScore = 3,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 5, 12),
                    new Stats("Удары в створ", 4, 8),
                    new Stats("Владение мячом", 44, 56)
                },
                SportType = SportEnum.Basketball
            },
            new MatchEvent()
            {
                HomeTeam = new Team("Челси", "FBIOperation.Images.chelseaLogo.png"),
                GuestTeam = new Team("Ливерпуль", "FBIOperation.Images.liverLogo.png"),
                League = new League("Английская Премьер-Лига", "АПЛ"),
                HomeTeamScore = 0,
                GuestTeamScore = 6,
                Stats = new List<Stats>()
                {
                    new Stats("Удары по воротам", 4, 10),
                    new Stats("Удары в створ", 1, 7),
                    new Stats("Владение мячом", 28, 62)
                },
                SportType = SportEnum.Basketball
            },
        };

        public MatchOverviewPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            SportFrame footballFrame = new SportFrame("#9CD4AC", "#C2E0C1", "Футбол", "ball.png", footballEvents);
            FlexLayout.SetBasis(footballFrame, 500);

            SportFrame hockeyFrame = new SportFrame("#4AA2BD", "#AECED8", "Хоккей", "puck.png", hockeyEvents);
            hockeyFrame.Margin = new Thickness(0, 25, 0, 0);
            FlexLayout.SetBasis(hockeyFrame, 500);

            SportFrame basketBallFrame = new SportFrame("#F59965", "#F2B18C", "Баскетбол", "bsball.png", basketballEvents);
            basketBallFrame.Margin = new Thickness(0, 25, 0, 0);
            FlexLayout.SetBasis(basketBallFrame, 500);

            Content = new ScrollView()
            {
                Orientation = ScrollOrientation.Vertical,
                VerticalScrollBarVisibility = ScrollBarVisibility.Never,
                Padding = new Thickness(25),
                Content = new FlexLayout()
                {
                    Direction = FlexDirection.Row,
                    Wrap = FlexWrap.Wrap,
                    AlignItems = FlexAlignItems.Start,
                    AlignContent = FlexAlignContent.Start,
                    JustifyContent = FlexJustify.SpaceEvenly,
                    Children =
                    {
                        footballFrame,
                        hockeyFrame,
                        basketBallFrame
                    }
                }
            };
        }
    }
}