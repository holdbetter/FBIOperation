using FBIOperation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace FBIOperation
{
    public class SportFrame : ContentView
    {
        public SportFrame(string mainColorHex, string secondColorHex, string nameOfSport, string imageName,
            List<MatchEvent> sportEvents)
        {
            CollectionView collectionView = new CollectionView()
            {
                ItemsSource = sportEvents,
                Header = new Label()
                {
                    Text = "Итог",
                    Margin = new Thickness(0, 4),
                    TextColor = Color.FromHex("#F3F3F3"),
                    FontSize = 14,
                    FontFamily = "Roboto-Bold",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center
                },
                ItemTemplate = new DataTemplate(() =>
                {
                    BoxView separator = new BoxView()
                    {
                        HeightRequest = 1,
                        BackgroundColor = Color.FromHex("#F3F3F3")
                    };
                    Grid.SetColumnSpan(separator, 3);

                    Label homeTeamLabel = new Label()
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        VerticalTextAlignment = TextAlignment.Center,
                        FontSize = 12,
                        FontFamily = "Roboto-Medium",
                        TextColor = Color.FromHex("#F3F3F3")
                    };
                    Grid.SetRow(homeTeamLabel, 1);
                    Grid.SetColumn(homeTeamLabel, 0);
                    homeTeamLabel.SetBinding(BindingContextProperty, "HomeTeam");
                    homeTeamLabel.SetBinding(Label.TextProperty, "Name");

                    Label guestTeamLabel = new Label()
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        VerticalTextAlignment = TextAlignment.Center,
                        FontSize = 12,
                        FontFamily = "Roboto-Medium",
                        TextColor = Color.FromHex("#F3F3F3")
                    };
                    Grid.SetRow(guestTeamLabel, 1);
                    Grid.SetColumn(guestTeamLabel, 2);
                    guestTeamLabel.SetBinding(BindingContextProperty, "GuestTeam");
                    guestTeamLabel.SetBinding(Label.TextProperty, "Name");

                    Label scoreTeam = new Label()
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 14,
                        FontFamily = "Roboto-Bold",
                        TextColor = Color.FromHex("#F3F3F3")
                    };
                    Grid.SetRow(scoreTeam, 1);
                    Grid.SetColumn(scoreTeam, 1);

                    scoreTeam.SetBinding(Label.TextProperty, "Score");

                    Grid item = new Grid()
                    {
                        ColumnSpacing = 0,
                        RowSpacing = 0,
                        RowDefinitions =
                        {
                            new RowDefinition() { Height = new GridLength(1, GridUnitType.Absolute) },
                            new RowDefinition() { Height = new GridLength(25, GridUnitType.Absolute) },
                        },
                        ColumnDefinitions =
                        {
                            new ColumnDefinition() { Width = GridLength.Star},
                            new ColumnDefinition() { Width = GridLength.Auto},
                            new ColumnDefinition() { Width = GridLength.Star},
                        },
                        Children =
                        {
                            separator,
                            homeTeamLabel,
                            scoreTeam,
                            guestTeamLabel
                        }
                    };

                    return item;
                })
            };
            collectionView.SelectionMode = SelectionMode.Single;
            collectionView.SelectionChanged += async (sender, e) =>
            {
                if (collectionView.SelectedItem != null)
                {
                    collectionView.SelectedItem = null;
                    MatchEvent matchEvent = e.CurrentSelection[0] as MatchEvent;
                    await Navigation.PushAsync(new MatchStatsDetailPage(matchEvent));
                }
            };

            Content = new Frame()
            {
                HeightRequest = 300,
                CornerRadius = 30,
                Padding = 0,
                BackgroundColor = Color.FromHex(mainColorHex),
                Content = new StackLayout()
                {
                    BackgroundColor = Color.Transparent,
                    Spacing = 0,
                    Children =
                    {
                        new StackLayout()
                        {
                            Orientation = StackOrientation.Horizontal,
                            Padding = new Thickness(32, 16),
                            Children =
                            {
                                new Image()
                                {
                                    Source = ImageSource.FromResource($"FBIOperation.Images.{imageName}", typeof(MatchOverviewPage).GetTypeInfo().Assembly),
                                    HeightRequest = 25,
                                    WidthRequest = 25,
                                    VerticalOptions = LayoutOptions.Center
                                },
                                new Label()
                                {
                                    Text = nameOfSport,
                                    TextColor = Color.FromHex("#F3F3F3"),
                                    FontSize = 18,
                                    FontFamily = "Roboto-Bold",
                                    Margin = new Thickness(8, 0, 0, 0),
                                    VerticalOptions = LayoutOptions.Center
                                },
                            }
                        },
                        new Frame()
                        {
                            BackgroundColor = Color.FromHex(secondColorHex),
                            HasShadow = false,
                            Padding = 0,
                            CornerRadius = 30,
                            HeightRequest = 500,
                            Content = collectionView
                        }
                    }
                }
            };
        }
    }
}