﻿using projectlufi.Models;
using projectlufi.ViewModels.UrunVM.AyakkabiVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.Views.UrunSayfalari.Ayakkabi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SporSayfasi : ContentPage
    {
        public SporSayfasi()
        {
            InitializeComponent();
            BindingContext = new SporViewModel();
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var urunler = e.CurrentSelection.FirstOrDefault() as ListItem;
            if (urunler == null)
                return;
            await Navigation.PushAsync(new DetaySayfasi(urunler));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}