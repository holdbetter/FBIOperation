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
    public partial class FirstBinding : ContentPage
    {
        public Person data = new Person()
        {
            Name = "Vilen",
            Age = 88
        };

        public FirstBinding()
        {
            InitializeComponent();

            //kavadrat.BindingContext = slider;
            //Binding binding = new Binding()
            //{
            //    Path = "Value",
            //    Mode = BindingMode.TwoWay,
            //    Source = slider
            //};

            secondEntry.BindingContext = chezarofl;
            secondEntry.SetBinding(Entry.TextProperty, "Text");
        }
    }
}