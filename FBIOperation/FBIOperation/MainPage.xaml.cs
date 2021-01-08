using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FBIOperation
{
    public partial class MainPage : ContentPage
    {
        List<Match> matches = new List<Match>()
        {
            new Match("Аякс", "Миджутланд", 3, 1),
            new Match("Атлетико Мадрид", "Локомотив", 0, 0),
            new Match("Бавария", "Зальцбург", 3, 1),
            new Match("Реал Мадрид", "Интер", 2, 0),
            new Match("Ливерпуль", "Аталанта", 0, 2),
            new Match("Марсель", "Порту", 0, 2),
            new Match("МюнхенгладБАХ", "Шахтер", 4, 0),
            new Match("Олимпииакос", "Манчестер Сити", 0, 1),
            new Match("Ювентус", "Ференкварос", 2, 1),
            new Match("Лацио", "Зенит", 3, 1),
            new Match("ПСЖ", "Лейпциг", 1, 0),
            new Match("Дортмунд", "Клуб Брюгге", 3, 0),
            new Match("Динамо Киев", "Барселона", 0, 4),
            new Match("Манчестер Юнайтед", "Стамбул какой-то", 4, 1),
        };

        public MainPage()
        {
            InitializeComponent();

            // СОЙДЕТ Х2
            // СОЙДЕТ, разметка опять же тут нормальная не будет
            // тут StackLayout неправильно юзать (мы юзали в качестве практики)
            // дальше будем заменять на ListView

            // второе задание отредачу потом, изменять нужно только футбол
            // чтобы рутиной не заниматься сейчас полгода

            footballMatch1.BindingContext = matches[0];
            footballMatch2.BindingContext = matches[1];
            footballMatch3.BindingContext = matches[2];
            footballMatch4.BindingContext = matches[3];
            footballMatch5.BindingContext = matches[4];
            footballMatch6.BindingContext = matches[5];
            footballMatch7.BindingContext = matches[6];
            footballMatch8.BindingContext = matches[7];
            footballMatch9.BindingContext = matches[8];
            footballMatch10.BindingContext = matches[9];
            footballMatch11.BindingContext = matches[10];
            footballMatch12.BindingContext = matches[11];
            footballMatch13.BindingContext = matches[12];
            footballMatch14.BindingContext = matches[13];

            footballImage.Source = ImageSource.FromResource("FBIOperation.Images.ball.png", typeof(MainPage).GetTypeInfo().Assembly);
            puckImage.Source = ImageSource.FromResource("FBIOperation.Images.puck.png", typeof(MainPage).GetTypeInfo().Assembly);
            basketballImage.Source = ImageSource.FromResource("FBIOperation.Images.bsball.png", typeof(MainPage).GetTypeInfo().Assembly);
        }

        // КТО НЕ ПОНЯЛ, ТОТ ПОЙМЕТ
        private void OpenMatchInfoPage(object sender, EventArgs e)
        {
            Match match = (sender as Button).Parent.BindingContext as Match;
            Navigation.PushAsync(new MatchStatsPage(match));
        }
    }
}
