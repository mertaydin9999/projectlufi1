using projectlufi.Models;
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
    public partial class AraSepetSayfasi : ContentPage
    {
        public AraSepetSayfasi(ListItem urunler)
        {
            InitializeComponent();
            BindingContext = urunler;
        }

        async void AlisveriseDon(object sender,EventArgs e)
        {
            await Navigation.PopAsync();
        }
        async void SepeteGit(object sender,EventArgs e)
        {
            var btn = sender as Button;
            var urunler = (ListItem)btn.CommandParameter;

            await Navigation.PushAsync(new SepetSayfasi(urunler));
        }
    }
}