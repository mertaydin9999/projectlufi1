using projectlufi.Models;
using projectlufi.ViewModels.UrunVM.AksesuarVM;
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
    public partial class DetaySayfasi : ContentPage
    {
        public DetaySayfasi(ListItem urunler)
        {
            InitializeComponent();
            BindingContext = urunler;
        }
        async void AraSepeteGit(object sender,EventArgs e)
        {
            var btn = sender as Button;
            var urunler = (ListItem)btn.CommandParameter;

            await Navigation.PushAsync(new AraSepetSayfasi(urunler));
        }
        public void Beden46(object sender,EventArgs e)
        {
            var btn = sender as Button;
            var urunler = (ListItem)btn.CommandParameter;
            urunler.UrunBeden = lblBeden.Text;

            lblBeden.Text = btn46.Text;
        }
        public void Beden48(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var urunler = (ListItem)btn.CommandParameter;
            urunler.UrunBeden = lblBeden.Text;
            lblBeden.Text = btn48.Text;
        }
        public void Beden50(object sender, EventArgs e)
        {
            lblBeden.Text = btn50.Text;
        }
        public void Beden52(object sender, EventArgs e)
        {
            lblBeden.Text = btn52.Text;
        }
        public void Beden54(object sender, EventArgs e)
        {
            lblBeden.Text = btn54.Text;
        }
        public void Beden56(object sender, EventArgs e)
        {
            lblBeden.Text = btn56.Text;
        }
    }
}