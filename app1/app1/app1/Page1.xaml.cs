using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            ScrollView scrollView = new ScrollView();
            scrollView.Scrolled += ScrollView_Scrolled;
        }

        private void Button_Clicked(object sender, EventArgs e) => Navigation.PushAsync(new Page2());

        private void Button_Clicked_1(object sender, EventArgs e) => Navigation.PushAsync(new Page3());

        private void Button_Clicked_2(object sender, EventArgs e) => Navigation.PushAsync(new Page4());

        private void Button_Clicked_3(object sender, EventArgs e) => Navigation.PushAsync(new Page5());

        private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
        {
            Console.WriteLine($"ScrollX: {e.ScrollX}, ScrollY: {e.ScrollY}");
        }
    }
}