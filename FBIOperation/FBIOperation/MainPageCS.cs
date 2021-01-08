using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace FBIOperation
{
    public class MainPageCS : ContentPage
    {
        private const int footballItogCountItems = 10;
        private const int basketballItogCountItems = 4;

        public MainPageCS()
        {
            #region Football
            StackLayout footballHeader = new StackLayout
            {
                Padding = new Thickness(16),
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Image
                    {
                        Margin = new Thickness(24, 0, 0, 0),
                        HeightRequest = 35,
                        WidthRequest = 35,
                        VerticalOptions = LayoutOptions.Center,
                        Source = ImageSource.FromResource("FBIOperation.Images.ball.png", typeof(MainPageCS).GetTypeInfo().Assembly)
                    },
                    new Entry
                    {
                        BackgroundColor = Color.Transparent,
                        Text = "Футбол",
                        FontSize = 24,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.White,
                        VerticalOptions = LayoutOptions.Center,
                        WidthRequest = 180,
                        HorizontalOptions = LayoutOptions.Start,
                        Margin = new Thickness(14, 0, 0, 0)
                    },
                    new Button
                    {
                        Text = "X",
                        BorderWidth = 3,
                        BorderColor = Color.FromHex("#FFD7CO"),
                        TextColor = Color.FromHex("#FFD7CO"),
                        FontAttributes = FontAttributes.Bold,
                        HeightRequest = 40,
                        WidthRequest = 40,
                        CornerRadius = 20,
                        VerticalOptions = LayoutOptions.Center,
                        BackgroundColor = Color.Transparent,
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        Margin = new Thickness(0, 0, 24, 0)
                    }
                }
            };

            StackLayout footballStackBody = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children =
                {
                    new Label
                    {
                        Text = "Итог",
                        TextColor = Color.FromHex("#F3F3F3"),
                        FontSize = 20,
                        Margin = new Thickness(0, 5),
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.FillAndExpand
                    },
                    new BoxView
                    {
                        BackgroundColor = Color.White,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        HeightRequest = 1.5
                    }
                }
            };

            for (int i = 0; i < footballItogCountItems; i++)
            {
                footballStackBody.Children.Add(new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    Spacing = 0,
                    Padding = new Thickness(0, 4),
                    Children =
                    {
                        new Label
                        {
                            Text = "ФК Москва",
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            VerticalOptions = LayoutOptions.Center,
                            TextColor = Color.FromHex("#F3F3F3")
                        },
                        new Label
                        {
                            Text = "0 : 1",
                            FontSize = 22,
                            FontAttributes = FontAttributes.Bold,
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            VerticalOptions = LayoutOptions.Center,
                            Margin = new Thickness(0, 0, 26, 0),
                            TextColor = Color.FromHex("#F3F3F3")
                        },
                        new Label
                        {
                            Text = "Сатурн",
                            HorizontalTextAlignment = TextAlignment.Center,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            VerticalOptions = LayoutOptions.Center,
                            TextColor = Color.FromHex("#F3F3F3")
                        }
                    }
                });

                if (i != 9)
                {
                    footballStackBody.Children.Add(new BoxView
                    {
                        BackgroundColor = Color.White,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        HeightRequest = 1.5
                    });
                }
            }

            Frame footballBody = new Frame
            {
                HasShadow = false,
                BackgroundColor = Color.FromHex("#C6E8CB"),
                VerticalOptions = LayoutOptions.FillAndExpand,
                CornerRadius = 30,
                Padding = new Thickness(0),
                HeightRequest = 500,
                Content = new ScrollView
                {
                    VerticalScrollBarVisibility = ScrollBarVisibility.Never,
                    Content = footballStackBody
                }
            };

            Frame footballFrame = new Frame()
            {
                Margin = Device.RuntimePlatform == Device.Android ? new Thickness(16, 16) :
                            Device.RuntimePlatform == Device.UWP ? new Thickness(24, 16) :
                            new Thickness(8),
                HeightRequest = 400,
                CornerRadius = 50,
                BackgroundColor = Color.FromHex("#9CD4AC"),
                Padding = new Thickness(0),
                Content = new StackLayout
                {
                    Children =
                    {
                        footballHeader, 
                        footballBody
                    }
                }
            };
            FlexLayout.SetBasis(footballFrame, new FlexBasis(600));
            #endregion

            #region Hockey
            Image puckImage = new Image()
            {
                Source = ImageSource.FromResource("FBIOperation.Images.puck.png", typeof(MainPageCS).GetTypeInfo().Assembly),
                HeightRequest = 35,
                WidthRequest = 35,
                Margin = new Thickness(40, 16, 0, 16),
                VerticalOptions = LayoutOptions.Center
            };
            Grid.SetRow(puckImage, 0);
            Grid.SetColumn(puckImage, 0);

            Label hockeyHeaderLabel = new Label()
            {
                Text = "Хоккей",
                TextColor = Color.FromHex("#F3F3F3"),
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Margin = new Thickness(16, 16, 0, 16)
            };
            Grid.SetRow(hockeyHeaderLabel, 0);
            Grid.SetColumn(hockeyHeaderLabel, 1);

            Switch hockeySwitch = new Switch()
            {
                IsToggled = true,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                Margin = new Thickness(0, 0, 60, 0),
                OnColor = Color.LightGray,
                ThumbColor = Color.Gray
            };
            Grid.SetRow(hockeySwitch, 0);
            Grid.SetColumn(hockeySwitch, 2);

            Label hockeyItogLabel = new Label
            {
                Text = "Итог",
                TextColor = Color.FromHex("#F3F3F3"),
                FontSize = 20,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            Grid.SetColumn(hockeyItogLabel, 0);
            Grid.SetColumnSpan(hockeyItogLabel, 3);
            Grid.SetRow(hockeyItogLabel, 0);

            Label hockeyHomeTeamLabel1 = new Label
            {
                Text = "ФК Москва",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyHomeTeamLabel1, 1);
            Grid.SetColumn(hockeyHomeTeamLabel1, 0);

            Label hockeyScoreLabel1 = new Label()
            {
                Text = "0 : 1",
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#F3F3F3"),
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("AECED8")
            };
            Grid.SetRow(hockeyScoreLabel1, 1);
            Grid.SetColumn(hockeyScoreLabel1, 1);

            Label hockeyGuestTeamLabel1 = new Label()
            {
                Text = "Сатурн",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyGuestTeamLabel1, 1);
            Grid.SetColumn(hockeyGuestTeamLabel1, 2);

            #region Labels
            Label hockeyHomeTeamLabel2 = new Label
            {
                Text = "ФК Москва",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyHomeTeamLabel2, 2);
            Grid.SetColumn(hockeyHomeTeamLabel2, 0);

            Label hockeyScoreLabel2 = new Label()
            {
                Text = "0 : 1",
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#F3F3F3"),
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("AECED8")
            };
            Grid.SetRow(hockeyScoreLabel2, 2);
            Grid.SetColumn(hockeyScoreLabel2, 1);

            Label hockeyGuestTeamLabel2 = new Label()
            {
                Text = "Сатурн",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyGuestTeamLabel2, 2);
            Grid.SetColumn(hockeyGuestTeamLabel2, 2);

            Label hockeyHomeTeamLabel3 = new Label
            {
                Text = "ФК Москва",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyHomeTeamLabel3, 3);
            Grid.SetColumn(hockeyHomeTeamLabel3, 0);

            Label hockeyScoreLabel3 = new Label()
            {
                Text = "0 : 1",
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#F3F3F3"),
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("AECED8")
            };
            Grid.SetRow(hockeyScoreLabel3, 3);
            Grid.SetColumn(hockeyScoreLabel3, 1);

            Label hockeyGuestTeamLabel3 = new Label()
            {
                Text = "Сатурн",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyGuestTeamLabel3, 3);
            Grid.SetColumn(hockeyGuestTeamLabel3, 2);

            Label hockeyHomeTeamLabel4 = new Label
            {
                Text = "ФК Москва",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyHomeTeamLabel4, 4);
            Grid.SetColumn(hockeyHomeTeamLabel4, 0);

            Label hockeyScoreLabel4 = new Label()
            {
                Text = "0 : 1",
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#F3F3F3"),
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("AECED8")
            };
            Grid.SetRow(hockeyScoreLabel4, 4);
            Grid.SetColumn(hockeyScoreLabel4, 1);

            Label hockeyGuestTeamLabel4 = new Label()
            {
                Text = "Сатурн",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyGuestTeamLabel4, 4);
            Grid.SetColumn(hockeyGuestTeamLabel4, 2);

            Label hockeyHomeTeamLabel5 = new Label
            {
                Text = "ФК Москва",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyHomeTeamLabel5, 5);
            Grid.SetColumn(hockeyHomeTeamLabel5, 0);

            Label hockeyScoreLabel5 = new Label()
            {
                Text = "0 : 1",
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#F3F3F3"),
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("AECED8")
            };
            Grid.SetRow(hockeyScoreLabel5, 5);
            Grid.SetColumn(hockeyScoreLabel5, 1);

            Label hockeyGuestTeamLabel5 = new Label()
            {
                Text = "Сатурн",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyGuestTeamLabel5, 5);
            Grid.SetColumn(hockeyGuestTeamLabel5, 2);

            Label hockeyHomeTeamLabel6 = new Label
            {
                Text = "ФК Москва",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyHomeTeamLabel6, 6);
            Grid.SetColumn(hockeyHomeTeamLabel6, 0);

            Label hockeyScoreLabel6 = new Label()
            {
                Text = "0 : 1",
                FontSize = 22,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#F3F3F3"),
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("AECED8")
            };
            Grid.SetRow(hockeyScoreLabel6, 6);
            Grid.SetColumn(hockeyScoreLabel6, 1);

            Label hockeyGuestTeamLabel6 = new Label()
            {
                Text = "Сатурн",
                HorizontalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#AECED8"),
                TextColor = Color.FromHex("F3F3F3")
            };
            Grid.SetRow(hockeyGuestTeamLabel6, 6);
            Grid.SetColumn(hockeyGuestTeamLabel6, 2);
            #endregion

            Grid hockeyBodyGrid = new Grid()
            {
                BackgroundColor = Color.White,
                RowSpacing = 1,
                ColumnSpacing = 0,
                RowDefinitions =
                {
                    new RowDefinition() { Height = GridLength.Star},
                    new RowDefinition() { Height = GridLength.Star},
                    new RowDefinition() { Height = GridLength.Star},
                    new RowDefinition() { Height = GridLength.Star},
                    new RowDefinition() { Height = GridLength.Star},
                    new RowDefinition() { Height = GridLength.Star},
                    new RowDefinition() { Height = GridLength.Star},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition() { Width = GridLength.Star},
                    new ColumnDefinition() { Width = GridLength.Auto},
                    new ColumnDefinition() { Width = GridLength.Star},
                },
                Children =
                {
                    hockeyItogLabel,
                    hockeyHomeTeamLabel1,
                    hockeyScoreLabel1,
                    hockeyGuestTeamLabel1,
                    hockeyHomeTeamLabel2,
                    hockeyScoreLabel2,
                    hockeyGuestTeamLabel2,
                    hockeyHomeTeamLabel3,
                    hockeyScoreLabel3,
                    hockeyGuestTeamLabel3,
                    hockeyHomeTeamLabel4,
                    hockeyScoreLabel4,
                    hockeyGuestTeamLabel4,
                    hockeyHomeTeamLabel5,
                    hockeyScoreLabel5,
                    hockeyGuestTeamLabel5,
                    hockeyHomeTeamLabel6,
                    hockeyScoreLabel6,
                    hockeyGuestTeamLabel6,
                }
            };

            Frame hockeyBodyFrame = new Frame()
            {
                HasShadow = false,
                BackgroundColor = Color.FromHex("#AECED8"),
                VerticalOptions = LayoutOptions.FillAndExpand,
                CornerRadius = 30,
                Padding = new Thickness(0),
                HeightRequest = 500,
                Content = hockeyBodyGrid
            };
            Grid.SetRow(hockeyBodyFrame, 1);
            Grid.SetColumn(hockeyBodyFrame, 0);
            Grid.SetColumnSpan(hockeyBodyFrame, 3);

            Grid hockeyMainGrid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition() { Width = new GridLength(75, GridUnitType.Absolute)},
                    new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star)},
                },
                RowDefinitions =
                {
                    new RowDefinition() { Height = GridLength.Auto},
                    new RowDefinition() { Height = GridLength.Star},
                },
                Children =
                {
                    puckImage,
                    hockeyHeaderLabel,
                    hockeySwitch,
                    hockeyBodyFrame
                }
            };

            Frame hockeyFrame = new Frame
            {
                Margin = Device.RuntimePlatform == Device.Android ? new Thickness(16, 16) :
                            Device.RuntimePlatform == Device.UWP ? new Thickness(24, 16) :
                            new Thickness(8),
                HeightRequest = 400,
                CornerRadius = 50,
                BackgroundColor = Color.FromHex("#4AA2BD"),
                Padding = new Thickness(0),
                Content = new StackLayout
                {
                    Children =
                    {
                        hockeyMainGrid
                    }
                }
            };
            FlexLayout.SetBasis(hockeyFrame, new FlexBasis(600));
            #endregion

            #region BasketBall
            FlexLayout basketballRowHolder = new FlexLayout()
            {
                Direction = FlexDirection.Column
            };

            for (int i = 0; i < basketballItogCountItems; i++)
            {
                FlexLayout basketballRow = new FlexLayout()
                {
                    Direction = FlexDirection.Row,
                    JustifyContent = FlexJustify.SpaceEvenly,
                    AlignItems = FlexAlignItems.Center,
                    Children =
                    {
                        new Label
                        {
                            Text = "ФК Москва",
                            TextColor = Color.FromHex("#F3F3F3")
                        },
                        new Label
                        {
                            Text = "0 : 1",
                            FontSize = 22,
                            FontAttributes = FontAttributes.Bold,
                            Margin = new Thickness(0, 0, 26, 0),
                            TextColor = Color.FromHex("#F3F3F3")
                        },
                        new Label
                        {
                            Text = "Сатурн",
                            TextColor = Color.FromHex("#F3F3F3")
                        }
                    }
                };
                FlexLayout.SetBasis(basketballRow, new FlexBasis(50));

                BoxView rowSeparator = new BoxView()
                {
                    BackgroundColor = Color.White
                };
                FlexLayout.SetAlignSelf(rowSeparator, FlexAlignSelf.Stretch);
                FlexLayout.SetBasis(rowSeparator, 2f);

                basketballRowHolder.Children.Add(basketballRow);
                basketballRowHolder.Children.Add(rowSeparator);
            }

            BoxView basketBallSeparator0 = new BoxView()
            {
                BackgroundColor = Color.White
            };
            FlexLayout.SetAlignSelf(basketBallSeparator0, FlexAlignSelf.Stretch);
            FlexLayout.SetBasis(basketBallSeparator0, 2f);


            Label basketballNameLabel = new Label()
            {
                Text = "Итог",
                TextColor = Color.FromHex("#F3F3F3"),
                FontSize = 20,
                Margin = new Thickness(0, 10),
                FontAttributes = FontAttributes.Bold
            };
            FlexLayout.SetAlignSelf(basketballNameLabel, FlexAlignSelf.Center);

            Frame basketballBodyFrame = new Frame()
            {
                HasShadow = false,
                BackgroundColor = Color.FromHex("#F2B18C"),
                CornerRadius = 30,
                Padding = new Thickness(0),
                Content = new FlexLayout()
                {
                    Direction = FlexDirection.Column,
                    Children =
                    {
                        basketballNameLabel,
                        basketBallSeparator0,
                        new ScrollView()
                        {
                            Content = basketballRowHolder
                        }
                    }
                }
            };
            FlexLayout.SetGrow(basketballBodyFrame, 1);

            Label basketballHeaderLabel = new Label()
            {
                Text = "Баскетбол",
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.White,
                Margin = new Thickness(16, 16, 0, 16)
            };
            FlexLayout.SetGrow(basketballHeaderLabel, 1);

            FlexLayout basketballHeader = new FlexLayout()
            {
                Direction = FlexDirection.Row,
                AlignItems = FlexAlignItems.Start,
                JustifyContent = FlexJustify.Start,
                Children =
                {
                    new Image()
                    {
                        Source = ImageSource.FromResource("FBIOperation.Images.bsball.png", typeof(MainPageCS).GetTypeInfo().Assembly),
                        Margin = new Thickness(40, 16, 0, 16),
                        HeightRequest = 35,
                        WidthRequest = 35
                    },
                    basketballHeaderLabel,
                    new CheckBox()
                    {
                        IsChecked = false,
                        BackgroundColor = Color.Transparent,
                        Color = Color.FromHex("#F2B18C"),
                        Margin = new Thickness(0, 16, 40 ,16)
                    }                    
                }
            };
            FlexLayout.SetBasis(basketballHeader, new FlexBasis(130));

            Frame basketBallFrame = new Frame()
            {
                Margin = Device.RuntimePlatform == Device.Android ? new Thickness(16, 16) :
                            Device.RuntimePlatform == Device.UWP ? new Thickness(24, 16) :
                            new Thickness(8),
                HeightRequest = 400,
                CornerRadius = 50,
                Padding = new Thickness(0),
                Content = new FlexLayout()
                {
                    Direction = FlexDirection.Column,
                    BackgroundColor = Color.FromHex("#E5824B"),
                    JustifyContent = FlexJustify.Start,
                    Wrap = FlexWrap.NoWrap,
                    AlignItems = FlexAlignItems.Start,
                    Children =
                    {
                        basketballHeader,
                        basketballBodyFrame
                    }
                }
            };
            FlexLayout.SetBasis(basketBallFrame, new FlexBasis(600));
            #endregion

            Content = new ScrollView
            {
                Content = new FlexLayout
                {
                    Direction = FlexDirection.Row,
                    Wrap = FlexWrap.Wrap,
                    AlignItems = FlexAlignItems.Start,
                    AlignContent = FlexAlignContent.SpaceEvenly,
                    JustifyContent = FlexJustify.SpaceAround,
                    Margin = Device.RuntimePlatform == Device.Android ? new Thickness(8) :
                            Device.RuntimePlatform == Device.UWP ? new Thickness(48) :
                            new Thickness(8),
                    Children = { footballFrame, hockeyFrame, basketBallFrame }
                }
            };
        }
    }
}