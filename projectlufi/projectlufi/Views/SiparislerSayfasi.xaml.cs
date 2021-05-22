using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SiparislerSayfasi : ContentPage
    {
        public SiparislerSayfasi()
        {
            InitializeComponent();
        }

        protected override async  void OnAppearing()
        {
            base.OnAppearing();
            listview.ItemsSource = await App.Database.GetListsAsync();
        }
    }
}